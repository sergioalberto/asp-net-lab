using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace HPlus.Ecommerce.Controllers
{

    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}