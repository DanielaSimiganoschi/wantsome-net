using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkWeek6
{
    abstract class Human
    {
        public string FirstName {  set; get; }
        public string MiddleName { protected set; get; }
        public string LastName { protected set; get; }
        public string SSN { protected set; get; }
        public string PermanentAddress { protected set; get; }
        public string PhoneNumber { protected set; get; }
        public string Email { protected set; get; }
        public string Course { protected set; get; }
    }
}
