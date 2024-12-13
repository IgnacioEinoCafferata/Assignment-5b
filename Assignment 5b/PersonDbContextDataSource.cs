using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5b
{
    internal class PersonDbContextDataSource : IPersonDataSource
    {
        private PersonContext _context = new();
        public PersonDbContextDataSource() 
        {
            _context.Database.EnsureCreated();
            _context.People.Load();
        }
        public IEnumerable<Person> GetPeople()
        {
            return _context.People.Local.ToBindingList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();        
        }
    }
}
