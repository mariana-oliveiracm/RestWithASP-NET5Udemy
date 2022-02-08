using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;


namespace RestWithASP_NET5Udemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

    }
}
