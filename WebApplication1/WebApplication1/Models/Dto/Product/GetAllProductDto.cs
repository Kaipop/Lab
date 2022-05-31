using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Dto.Product
{
    public class GetAllProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImgUrl { get; set; }
        public string Tag { get; set; }
    }
}
