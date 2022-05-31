using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModel.View
{
    public class ProductDetailsViewModel
    {
        public ProductData Product { get; set; }
        public class ProductData
        {
            public int id { get; set; }
            public string Name { get; set; }
            public decimal UnitPrice { get; set; }
            public string ImgUrl { get; set; }
        }
    }
}
