using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5b
{
    public interface IPersonDataSource
    {
        public IEnumerable<Person> GetPeople();
        public void SaveChanges();
    }
}
