using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}