using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult List(){
            return View();
        }

        public IActionResult Details(int id){
            var p = new Product();
            p.Name = "samsung s6";
            p.Description = "telefon";
            p.Price = 1000;

            return View(p);
        }
    }
}