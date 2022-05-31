using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModel.View
{
    public class ProductIndexViewModel
    {
        public string Title { get; set; }

        public IEnumerable<ProductData> ProductList { get; set; }
        public class ProductData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal UnitPrice { get; set; }
            public string Tag { get; set; }
        }
    }
}
