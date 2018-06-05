using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComsumeWebApi;
using ConsumeSubCategory.Exception1;
using ConsumeSubCategory.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeSubCategory.Controllers
{
    public class Consume2Controller : Controller
    {


        //view for index
        [ExceptionConsimungSubCategory]
        public IActionResult Index()
        {
            return View();
        }

        //view for insert
        [ExceptionConsimungSubCategory]
        public ActionResult Insert()
        {
            return View();
        }

        //view for display
        [ExceptionConsimungSubCategory]
        public ActionResult Display()
        {
            HttpCommunication<Category> obj = new HttpCommunication<Category>("http://localhost:1309/api/");
            obj.ServiceAddress = "Products";
            var result = obj.GetRecords();

            ViewBag.res = result;
            return View();
        }


        


    }
}