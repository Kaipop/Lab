using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository.Interface
{
    public interface IProductRepositroy : IDBRepository
    {
        public void DeleteById(int id);
    }
}
