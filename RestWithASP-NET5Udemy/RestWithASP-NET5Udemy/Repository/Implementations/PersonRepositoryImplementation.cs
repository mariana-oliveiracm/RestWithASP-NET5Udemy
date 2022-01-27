using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASP_NET5Udemy.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
        //private volatile int count;
        private SqlContext _context;

        public PersonRepositoryImplementation(SqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
            return person;

        }

        public void Delete(long id)
        {
            try
            {
                var foundPerson = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
                if (foundPerson != null)
                {
                    _context.Persons.Remove(foundPerson);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Person> FindAll()
        {
            /*List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;*/
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            /*return new Person
            {
                //Id = IncrementAndGet(),
                Id = 1,
                FirstName = "Julia",
                LastName = "Winston",
                Address = "BH MG Brasil",
                Gender = "Female"
            };*/
            var person = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            return person;

        }

        public Person Update(Person person)
        {
            try
            {
                var foundPerson = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
                if (foundPerson != null)
                {
                    _context.Entry(foundPerson).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return person;
        }

       /* private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "MockFirstName" + i ,
                LastName = "MockLastName" + i,
                Address = "MockAdress" + i,
                Gender = "MockGender" + i
            };
        }*/

        /*private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }*/
    }
}
