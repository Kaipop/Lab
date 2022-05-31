using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Dto.Product;

namespace WebApplication1.Service.Interface
{
    public interface IProductService
    {
        public IEnumerable<GetAllProductDto> GetAllProduct();
        public GetProductDto GetProduct(int id);
        public void UpdateProduct(UpdateProductDto request);
    }
}
