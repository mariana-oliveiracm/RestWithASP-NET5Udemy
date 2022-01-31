using RestWithASP_NET5Udemy.Data.VO;
using System.Collections.Generic;


namespace RestWithASP_NET5Udemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
        //Book Create(Book book);
        //Book FindById(long id);
        //List<Book> FindAll();
        //Book Update(Book book);
        //void Delete(long id);

    }
}
