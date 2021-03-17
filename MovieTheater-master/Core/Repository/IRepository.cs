using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Repository
{
    public interface IRepository<T> where T:class
    {
        List<T> GetAll();
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void AddList(List<T> entities);
    }
}
