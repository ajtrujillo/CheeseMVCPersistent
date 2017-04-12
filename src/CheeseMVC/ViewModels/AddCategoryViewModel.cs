using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels

{
    [Display{Name = "Category Name")]
    public class AddCategoryViewModel
    {
        public string Name { get; set;  }
    }
}
