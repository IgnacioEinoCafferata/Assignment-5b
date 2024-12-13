using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5b
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person()
        {
            Id = 0;
            Name = "";
            Phone = "";
        }

        public Person(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
}
