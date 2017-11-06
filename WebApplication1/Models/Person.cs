using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandIn3.Models
{
    public abstract class Person
    {
        private String name;
        private String email;
        private String password;
        private int age;

        public String Name
        {
            get; set; 
        }

        public String Email { get; set; }
        public String Password { get; set; }
        public int Age { get; set; }

        public Person(String name, String email, String password, int age) {
            Name = name;
            Email = email;
            Password = password;
            Age = age;
        }

        public Person() { }

        public virtual String ChangeEmail(String email) {
            this.email = email;
            return Email;
        }

        override public String ToString() {
            return string.Format("Name : {0}   Email : {1}   Age : {2}", name, email, age);
        }
    }
}
