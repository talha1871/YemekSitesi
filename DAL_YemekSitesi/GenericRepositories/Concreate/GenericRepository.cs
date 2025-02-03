using DAL_YemekSitesi.GenericRepositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;
using System.Linq.Expressions;
using DAL_YemekSitesi.Context;

namespace DAL_YemekSitesi.GenericRepositories.Concreate
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }
        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges(); 
        }


        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
    
        }


    }

}
