﻿using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;


namespace RestWithASP_NET5Udemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
        //Person Create(Person person);
        //Person FindById(long id);
        //List<Person> FindAll();
        //Person Update(Person person);
        //void Delete(long id);

    }
}
