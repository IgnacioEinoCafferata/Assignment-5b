using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5b
{
    internal class PersonListDataSource : IPersonDataSource
    {
        private readonly List<Person> _people = new List<Person>();

        public PersonListDataSource()
        {
            _people.Add(new Person(0, "Tom", "5555-5555"));
            _people.Add(new Person(1, "Jhon", "1111-1111"));
            _people.Add(new Person(2, "Joseph", "2222-2222"));
        }
        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList();
        }
        public void SaveChanges()
        {

        }
    }
}
