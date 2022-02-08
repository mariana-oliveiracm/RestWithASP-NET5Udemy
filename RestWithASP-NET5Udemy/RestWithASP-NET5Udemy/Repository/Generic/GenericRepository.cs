using Microsoft.EntityFrameworkCore;
using RestWithASP_NET5Udemy.Model.Base;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected SqlContext _context;
        private DbSet<T> dataset;

        public GenericRepository(SqlContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }
        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            return item;
        }

        public void Delete(long id)
        {
            try
            {
                var foundItem = dataset.SingleOrDefault(p => p.Id.Equals(id));
                if (foundItem != null)
                {
                    dataset.Remove(foundItem);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            var item = dataset.SingleOrDefault(p => p.Id.Equals(id));
            return item;
        }

        public T Update(T item)
        {
            try
            {
                var foundItem = _context.Persons.SingleOrDefault(p => p.Id.Equals(item.Id));
                if (foundItem != null)
                {
                    _context.Entry(foundItem).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return item;
        }
    }
}
