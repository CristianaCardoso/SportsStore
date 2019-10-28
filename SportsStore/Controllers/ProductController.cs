using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
      //lista de  prodtutos
        public IActionResult Index()
        {
            return View();
        }
    }
}
