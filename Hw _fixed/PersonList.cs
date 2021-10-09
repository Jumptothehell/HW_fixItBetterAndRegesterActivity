using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        public void FetchcPersonList()
        {
            Console.WriteLine("List Person");
            Console.WriteLine("------------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name: {0} \nType: Student\n", person.Getname());
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("Name: {0} \nType: Teacher\n", person.Getname());
                }
            }
        }
        public bool CheckValidUserID(string UserID)
        {
            return personList.Exists(x => x.GetID() == UserID);
        }
        public bool CheckValidPasswordID(string PasswordID)
        {
            return personList.Exists(x => x.GetcitizenID() == PasswordID);
        }
        public Person FindByID(string UserID)
        {
            return personList.Find(x => x.GetID() == UserID);
        }
    }
}
