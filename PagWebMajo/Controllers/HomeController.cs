using Microsoft.AspNetCore.Mvc;
using PagWebMajo.Models;
using System.Diagnostics;

namespace PagWebMajo.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
