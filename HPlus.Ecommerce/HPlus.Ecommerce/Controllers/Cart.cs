using Microsoft.AspNetCore.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class CartController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}