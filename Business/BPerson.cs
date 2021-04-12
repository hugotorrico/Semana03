using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
    public class BPerson
    {
        DPerson dPerson = new DPerson();

        public List<Person> GetPeopleByLastName(string LastName)
        {
            return dPerson.GetPeople(LastName, string.Empty);
        }

        public List<Person> GetPeopleByLastNameFirstName(string LastName, string FirstName)
        {
            return dPerson.GetPeople(LastName, FirstName);
        }

        public List<Person> GetPeopleTop5()
        {
            return dPerson.GetPeople(string.Empty, string.Empty).Take(5).ToList();
        }
    }
}
