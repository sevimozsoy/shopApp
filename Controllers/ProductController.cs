using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public string Index(){
            return "product/index";
        }

        public string List(){
            return "product/list";
        }

        public string Details(int id){
            return "product/details "+id;
        }
    }
}