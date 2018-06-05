using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubCategoryAPI.Exceptions1;
using SubCategoryAPI.Models;

namespace SubCategoryAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/SubCategory")]
    public class SubCategoryController : Controller
    {
        private readonly SlipCartDatabaseContext db;

        public SubCategoryController(SlipCartDatabaseContext db)
        {
            this.db = db;
        }

        //list of all sub category
        [ExceptionSubCategoryAPI]
        [HttpGet]
        public List<SubCategory> GetSubCategory()
        {
            return db.SubCategory.ToList();

        }


        //insert new sub category
        [ExceptionSubCategoryAPI]
        [HttpPost]
        public IActionResult PostSubCategory([FromBody] SubCategory subcat)

        {
            db.Add(subcat);
            db.SaveChanges();
            return new ObjectResult("Object has been added");

        }

        //delete sub category
        [ExceptionSubCategoryAPI]
        [HttpDelete("{id}")]
        public IActionResult DeleteSubCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = db.SubCategory.Find(id);
            db.SubCategory.Remove(obj);
            db.SaveChanges();
            return new ObjectResult("Deleted Successfully");
        }

    }

}


    
