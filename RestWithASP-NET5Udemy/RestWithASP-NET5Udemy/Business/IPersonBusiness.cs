using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;


namespace RestWithASP_NET5Udemy.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
