using DongVanThanh.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string _policyName = "CorsPolicy";
string _anotherPolicy = "AnotherCorsPolicy";
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json")
           .Build();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: _policyName, builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
    opt.AddPolicy(name: _anotherPolicy, builder =>
    {
        builder.WithOrigins("https://localhost:7281")
                .AllowAnyHeader()
                .AllowAnyMethod();
    });
});
builder.Services.AddDbContext<OrderDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
