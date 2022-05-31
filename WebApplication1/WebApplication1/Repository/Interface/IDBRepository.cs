using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DBEntity;

namespace WebApplication1.Repository.Interface
{
    public interface IDBRepository
    {
        public TPE21_Winter_BuildSchool_LabContext DBContext { get; }

        public void Create<T>(T entity) where T : class;
        public void Update<T>(T entity) where T : class;
        public void Delete<T>(T entity) where T : class;
        public IQueryable<T> GetAll<T>() where T : class;
        public void Save();
    }
}
