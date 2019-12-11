using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Person
    {
        public int IdNumber { get; }
        public string FirstName { get; }
        public string FamilyName { get; }

        public Person(int newIdNumber, string newFirstName, string newFamilyName)
        {
            this.IdNumber = newIdNumber;
            this.FirstName = newFirstName;
            this.FamilyName = newFamilyName;
        }

        public override string ToString()
        {
            return this.IdNumber+". "+this.FirstName+" "+this.FamilyName;
        }
    }
}
