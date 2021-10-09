using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;
        protected string ID;

        //public Person(string name, string address, string citizenID) 
        //{
        //    this.name = name;
        //    this.address = address;
        //    this.citizenID = citizenID;
        //}
        public Person(string name, string address, string citizenID, string ID)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
            this.ID = ID;
        }
        public string Getname() 
        {
            return this.name;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public string GetID()
        {
            return this.ID;
        }
        public string GetcitizenID()
        {
            return this.citizenID;
        }
    }
}
