using CheeseMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CheeseMVC.Models;

namespace CheeseMVC.Controllers
{
    public class CategoryController: Controller
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }
            //GET: /<controller>/

    public IActionResult Index()
    {
            List<CheeseCategory> categories = context.Categories.ToList();

        return View(categories);
    }

    }


}
