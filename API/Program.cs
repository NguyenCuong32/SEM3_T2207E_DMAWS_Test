using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
//Add cors
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
            policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            }
        );
}
);

// Add services to the container.
//builder.services.addcontrollers();
// learn more about configuring swagger/openapi at https://aka.ms/aspnetcore/swashbuckle
//builder.services.addendpointsapiexplorer();
//var connectionstring = builder.configuration.getconnectionstring("ordersystem");
//        options => options.usesqlserver(connectionstring)
       // );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
