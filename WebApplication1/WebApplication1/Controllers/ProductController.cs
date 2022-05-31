using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Dto.Product;
using WebApplication1.Models.ViewModel.Data;
using WebApplication1.Models.ViewModel.View;
using WebApplication1.Service.Interface;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productList = _productService.GetAllProduct().Select(x => new ProductIndexViewModel.ProductData
            {
                Id = x.Id,
                Name = x.Name,
                UnitPrice = x.UnitPrice,
                Tag = x.Tag
            });
            var result = new ProductIndexViewModel
            {
                Title = "安安的店",
                ProductList = productList
            };

            return View(result);
        }

        public IActionResult ProductDetail(int id)
        {
            var productDto = _productService.GetProduct(id);
            var product = new ProductDetailsViewModel.ProductData
            {
                id = productDto.Id,
                Name = productDto.Name,
                ImgUrl = productDto.ImgUrl,
                UnitPrice = productDto.UnitPrice
            };

            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductEditDataModel request)
        {
            //viewmodel要轉回成DTO去編輯
            var productDto = new UpdateProductDto
            {
                Id = request.Id,
                Name = request.Name,
                UnitPrice = request.UnitPrice
            };

            _productService.UpdateProduct(productDto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
