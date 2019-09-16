using Cookiesss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookiesss.Controllers
{
    public class UsersController : Controller
    {
        UsersContext crudobject;
        public UsersController()
        {
            crudobject = new UsersContext();              
        }
        // GET: Users
        public ActionResult Login()
        {
            if(Request.Cookies["SessionCreator"]!=null)
            {
                return RedirectToAction("Index", "UserWelcome");             
            }

            else
            {
                return View();
            }            
        }

        [HttpPost]
        public ActionResult Login(AppUsers user)
        {
            var usr = crudobject.AppUsers.Single(a => a.UserName == user.UserName && a.Password == user.Password);
            
            if(usr!=null)
            {

                HttpCookie cookie = new HttpCookie("SessionCreator");
                cookie["Name"] = usr.Name;
                cookie["UserName"] = usr.UserName;
                cookie["Password"] = usr.Password;
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "UserWelcome");
            }      
            
            else
            {
                return View();
            }     
        }
    }
}