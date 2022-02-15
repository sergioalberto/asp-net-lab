using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Web;
// using System.Web.Security;

namespace HPlus.Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            /* if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            } */

            return View();
        }
    }
}