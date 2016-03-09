using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDirectory
{
    public class Student
    {
            public string userName { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string major { get; set; }

        public override string ToString()
        {
            string x = "Username: " + userName + Environment.NewLine + "First Name: " + firstName + Environment.NewLine + "Last Name: " + lastName + Environment.NewLine + "Email: " + email + Environment.NewLine + "Phone: " + phone + Environment.NewLine + "Major: " + major;
            return x;

        }
    }
   
        }