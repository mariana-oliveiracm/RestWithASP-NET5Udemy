﻿using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;


namespace RestWithASP_NET5Udemy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);

    }
}
