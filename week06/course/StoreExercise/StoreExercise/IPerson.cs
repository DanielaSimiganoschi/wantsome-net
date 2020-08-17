using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}
