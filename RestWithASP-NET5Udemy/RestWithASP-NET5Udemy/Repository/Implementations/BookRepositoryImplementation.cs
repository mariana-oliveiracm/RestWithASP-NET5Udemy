/*using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASP_NET5Udemy.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {
        //private volatile int count;
        private SqlContext _context;

        public BookRepositoryImplementation(SqlContext context)
        {
            _context = context;
        }

        public Book Create(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
            return book;

        }

        public void Delete(long id)
        {
            try
            {
                var foundBook = _context.Books.SingleOrDefault(p => p.Id.Equals(id));
                if (foundBook != null)
                {
                    _context.Books.Remove(foundBook);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(long id)
        {
            var book = _context.Books.SingleOrDefault(p => p.Id.Equals(id));
            return book;

        }

        public Book Update(Book book)
        {
            try
            {
                var foundBook = _context.Persons.SingleOrDefault(p => p.Id.Equals(book.Id));
                if (foundBook != null)
                {
                    _context.Entry(foundBook).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return book;
        }

    }
}
*/