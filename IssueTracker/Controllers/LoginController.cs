using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using IssueTrackerBase.Data;
using System.Linq;
using IssueTracker.Models;

namespace IssueTracker.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            if(Request.IsAuthenticated)
            {
                return RedirectToAction("GetAllAgileBoardDetails", "Agile");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                // Lets first check if the Model is valid or not
                using (var entities = new IssueTrackerEntities())
                {
                    string name = model.UserName;
                    string pass = model.Password;

                    // Now if our password was enctypted or hashed we would have done the
                    // same operation on the user entered password here, But for now
                    // since the password is in plain text lets just authenticate directly

                    bool userValid = entities.Users.Any(user => user.EmailId == name && user.Password == pass);

                    // User found in the database
                    if (userValid)
                    {
                        FormsAuthentication.SetAuthCookie(name, false);
                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("GetAllAgileBoardDetails", "Agile");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "The user name or password provided is incorrect.");
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("GetAllAgileBoardDetails", "Agile");
        }
    }
}