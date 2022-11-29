using SalesCore.Application.Data;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Application.Repository
{
    public class BaseRepository<T>: IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        

        public string Create(T model)
        {
            _dbContext.Set<T>().Add(model);
            _dbContext.SaveChanges();
            return "ok";
        }
        public string Delete(T model)
        {
            _dbContext.Set<T>().Remove(model);
            _dbContext.SaveChanges();
            return "deleted";
        }
        public string Update(T model)
        {
            _dbContext.Set<T>().Update(model);
            _dbContext.SaveChanges();
            return "Updated";
        }
        public T? GetById(int model)
        {
            return _dbContext.Set<T>().Find(model);

        }
        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

       
    }
}
