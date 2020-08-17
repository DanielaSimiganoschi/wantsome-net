using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Person : IPerson
    {
        public string NamePerson { get ; set; }

        public Person( string nume)
        {
            this.NamePerson = nume;
        }
    }
}
