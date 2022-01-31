﻿using RestWithASP_NET5Udemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestWithASP_NET5Udemy.Data.VO
{

    public class PersonVO
    {
        //[JsonPropertyName("code")]
        public long Id { get; set; }

        //[JsonPropertyName("name")]
        public string FirstName { get; set; }

        //[JsonPropertyName("last_name")]
        public string LastName { get; set; }

        //[JsonIgnore]
        public string Address { get; set; }

        //[JsonPropertyName("sex")]
        public string Gender { get; set; }

    }
    
}
