using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models.DBEntity
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
    }
}
