using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        private void Save()
        {
            _context.SaveChanges();
        }

        public void Add(T t)
        {
            _context.Add(t);
            Save();
        }

        public void Update(T t)
        {
            _context.Update(t);
            Save();
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            Save();
        }
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }
    }
}
