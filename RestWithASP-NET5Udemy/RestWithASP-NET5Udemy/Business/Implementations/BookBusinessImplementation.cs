﻿using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using RestWithASP_NET5Udemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        //private volatile int count;
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);

        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);

        }
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}