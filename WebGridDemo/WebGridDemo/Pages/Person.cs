using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGridDemo.Pages
{
    public class Person
    {
       

        public String Name { get; set; }
        public String Surname { get; set; }
        public String Status { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public bool Employed { get; set; }

        public Person(string name, string surname, string status, int age, DateTime birthday, bool employed)
        {
            Name = name;
            Surname = surname;
            Status = status;
            Age = age;
            Birthday = birthday;
            Employed = employed;
        }

    }
}
