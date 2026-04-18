// Controllers/HomeController.cs
using Lab4_Productos_C12585.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_Productos_C12585.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Error() => View();
    }
}