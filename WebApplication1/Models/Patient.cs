using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandIn3.Models;

namespace WebApplication1.Models
{
    public class Patient : Person
    {
        private String socialSecurityNumber;
        public String SocialSecurityNumber {get; set; }

        public Patient(String name, int age, String email, String password, String socialSecurityNumber) : base(name, email, password, age)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }

        public Patient() { }
        override public String ToString()
        {
            return string.Format("Name : {0}   Email : {1}   Age : {2}   Social security number : {3}", Name, Email, Age, SocialSecurityNumber);
        }
    }
}