using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DBEntity;
using WebApplication1.Repository.Interface;

namespace WebApplication1.Repository
{
    public class DBRepository : IDBRepository
    {
        private readonly TPE21_Winter_BuildSchool_LabContext _dbContext;
        public DBRepository(TPE21_Winter_BuildSchool_LabContext dbContext)
        {
            _dbContext = dbContext;
        }
        public TPE21_Winter_BuildSchool_LabContext DBContext { get { return _dbContext; } }

        public void Create<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Added;
        }

        public void Update<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _dbContext.Set<T>();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
