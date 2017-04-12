using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CheeseMVC.Controllers
{
    public class CategoryController: Controller
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }
    }

    //GET: /<controller>/

    public IActionResult Index()
    {
        List<CategoryController> categories = context.Categories.ToList();

        return View(categories);
    }

}
