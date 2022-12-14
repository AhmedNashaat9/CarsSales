using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Application.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        string Create(T entity);
        string Delete(T entity);
        string Update(T entity);
        T? GetById(int entity);
        List<T> GetAll();

    }
}
