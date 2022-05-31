using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DBEntity;
using WebApplication1.Models.Dto.Product;
using WebApplication1.Repository.Interface;
using WebApplication1.Service.Interface;

namespace WebApplication1.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepositroy _productRepository;
        public ProductService(IProductRepositroy productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<GetAllProductDto> GetAllProduct()
        {
            return _productRepository.GetAll<Product>().Select(x => new GetAllProductDto
            {
                Id = x.Id,
                Name = x.Name,
                UnitPrice = x.Price,
                Tag = x.Price > 200 ? "很貴" : "便宜"
            });
        }

        public GetProductDto GetProduct(int id)
        {
            var soruce = _productRepository.GetAll<Product>().FirstOrDefault(x => x.Id == id);
            return new GetProductDto
            {
                Id = soruce.Id,
                Name = soruce.Name,
                UnitPrice = soruce.Price,
                ImgUrl = soruce.ImgUrl,
            };
        }

        public void UpdateProduct(UpdateProductDto request)
        {
            var target = _productRepository.GetAll<Product>().First(x => x.Id == request.Id);
            target.Name = request.Name;
            target.Price = request.UnitPrice;
            _productRepository.Update(target);
            _productRepository.Save();
        }
    }
}
