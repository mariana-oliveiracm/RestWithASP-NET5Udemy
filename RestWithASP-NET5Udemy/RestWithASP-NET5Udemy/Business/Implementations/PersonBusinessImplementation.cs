using RestWithASP_NET5Udemy.Data.Converter.Implementations;
using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using RestWithASP_NET5Udemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Business.Implementations
{

    public class PersonBusinessImplementation : IPersonBusiness
    {

        //private readonly IRepository<Person> _repository;
        private readonly IPersonRepository _repository;
        private readonly PersonConverter _converter;

        //public PersonBusinessImplementation(IRepository<Person> repository)
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public PersonVO Disable(long id)
        {
            var personEntity = _repository.Disable(id);
            return _converter.Parse(personEntity);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));

        }

        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.Parse(_repository.FindByName(firstName, lastName));
        }

        public PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
        {

            var sort = (!string.IsNullOrWhiteSpace(sortDirection)) && !sortDirection.Equals("desc") ? "asc" : "desc";
            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            string query = @"SELECT * FROM person p WHERE 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(name)) query += $"AND p.first_name like '%{name}%' ";
            query += $"ORDER BY p.first_name {sort} OFFSET {offset} ROWS FETCH NEXT {size} ROWS ONLY";

            string countQuery = @"SELECT COUNT(*) FROM person p WHERE 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(name)) countQuery += $"AND p.first_name like '%{name}%' ";

            var persons = _repository.FindWithPagedSearch(query);
            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchVO<PersonVO> 
            {
                CurrentPage = page,
                List = _converter.Parse(persons),
                PageSize = size,
                SortDirections = sort,
                TotalResults = totalResults
            };
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }

    //public class PersonBusinessImplementation : IPersonBusiness
    //{
    //    //private volatile int count;
    //    //private readonly IPersonRepository _repository;
    //    private readonly IRepository<Person> _repository;

    //    public PersonBusinessImplementation(IRepository<Person> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public Person Create(Person person)
    //    {
    //        return _repository.Create(person);

    //    }

    //    public void Delete(long id)
    //    {
    //        _repository.Delete(id);
    //    }

    //    public List<Person> FindAll()
    //    {
    //        return _repository.FindAll();
    //    }

    //    public Person FindById(long id)
    //    {
    //        return _repository.FindById(id);

    //    }

    //    public Person Update(Person person)
    //    {
    //        return _repository.Update(person);
    //    }
    //}
}
