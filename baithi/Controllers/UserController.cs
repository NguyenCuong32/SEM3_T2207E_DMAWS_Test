using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppCrudMVC.Controllers
{
    public class UserController : Controller
    {
        TestDataEntities data =  new TestDataEntities();
        // GET: User
        public ActionResult Index()
        {
            return View(data.User.ToList());//this is model return for indexview
        }
        
    //THIS TO SHOW CREATE VIEW
    public ActionResult Create() {
            return View();
        }
        //THIS TO ADD  DATA FROM VIEW TO DATABASE
        [HttpPost]
    public ActionResult Create(User acc)
        {
            data.User.Add(acc);
            data.SaveChanges();
            return View();
        }

    //THIS TO  SHOW DATA TO CONTROL ON EDIT VIEW
    public ActionResult Edit(int id)
        {
            User acc = data.User.Find(id);
            return View(acc);//THIS IS MODEL OBJECT RETURN TO VIEW
        }
        //THIS TO UPDATE DATA FROM CONTROL TO DATABASE
        [HttpPost]
    public ActionResult Edit(User acc)
        {
            User ac = data.User.Find(acc.Id);
            ac.Name = acc.Name;
            ac.Address = acc.Address;
            ac.Username = acc.Username;
            ac.Password = acc.Password;

            data.SaveChanges();
            return View();
        }
    public ActionResult Details(int id)
        {
            User acc = data.User.Find(id);
            return View(acc);
        }
    public ActionResult Delete(int? id)
        {
            User acc = data.User.Find(id);
            return View(acc);
        }
    [HttpPost]
    public ActionResult Delete(int id)
        {
            User acc = data.User.Find(id);
            data.User.Remove(acc);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}