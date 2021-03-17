using Core.Repository;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business
{
    public class BaseRepository<T> : IRepository<T>
        where T : class
    {

        public void Add(T entity)
        {
            using var context = new ApplicationDbContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void AddList(List<T> entities)
        {
            using var context = new ApplicationDbContext();
            context.Set<T>().AddRange(entities);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new ApplicationDbContext();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new ApplicationDbContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var context = new ApplicationDbContext();
            return context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using var context = new ApplicationDbContext();
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
