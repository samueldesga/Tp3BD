using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
    public class EfEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        private readonly DbContext _context;
        public EfEntityRepository()
        {
            _context = new TutoringDbContext();
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();

        }

        public T GetById(int id)
        {
            return _context.Set<T>().FirstOrDefault(t => t.Id == id);
           
        }

        public void delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
