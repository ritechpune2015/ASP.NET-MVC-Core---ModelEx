using Microsoft.AspNetCore.Mvc;
using ModelEx.Models;
namespace ModelEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetModel()
        {
          //  Emp e = new Emp();
            Product p=new Product();
            return View(p);
        }

        public IActionResult GetEmps()
        {
            //Emp e = new Emp();
            var e = Emp.GetEmps();
            return View(e);
        }

    }
}
