using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandIn3.Models;
using System.Text.RegularExpressions;

namespace WebApplication1.Models
{
    public class Dentist : Person
    {
        public Dentist(String name, String email, String password, int age) : base(name, email, password, age) { }

        public override String ChangeEmail(string email)
        {
            String pattern = @"*@odont.dk";
            Regex reg = new Regex(pattern);

            Match m = reg.Match(email);
            if (m.Success)
            {
                base.ChangeEmail(email);
                return Email;
            }
            else {
                throw new EmailFormatException("Format of email does not end in @odont.dk");
            }
        }
    }
}