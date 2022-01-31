using RestWithASP_NET5Udemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP_NET5Udemy.Data.VO
{

    public class PersonVO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

    }
    
}
