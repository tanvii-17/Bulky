using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.ViewModels
{
    //VM -- View bounded tightly to a specific model
    public class ProductVM
    {
        public Product Product { get; set; }
        //IEnumerable to hold a dropdown
        [ValidateNever]
        public IEnumerable<SelectListItem> categoryList { get; set; }
    }
}
