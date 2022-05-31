using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DBEntity;
using WebApplication1.Repository.Interface;

namespace WebApplication1.Repository
{
    public class ProductRepository : DBRepository, IProductRepositroy
    {
        public ProductRepository(TPE21_Winter_BuildSchool_LabContext dbContext) : base(dbContext)
        {

        }
        //客製的方法//針對資料庫的操作
        public void DeleteById(int id)
        {
            var target = DBContext.Products.First(x => x.Id == id);
            Delete<Product>(target);
        }
    }
}
