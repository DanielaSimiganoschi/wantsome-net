using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    class Student : People, Comment
    {

        public int UniqueClassIdentifier { get; private set; }
        public string UniqueIdIdentifier { private set; get; }
        public string Comment { set; get; }

        public Student(int uniqueClassIdentifier, string name)
        {
            this.UniqueClassIdentifier = uniqueClassIdentifier;
            this.Name = name;
            UniqueIdIdentifier = System.Guid.NewGuid().ToString();
        }

        public Student(int uniqueClassIdentifier, string name, string comment)
        {
            this.UniqueClassIdentifier = uniqueClassIdentifier;
            this.Name = name;
            UniqueIdIdentifier = System.Guid.NewGuid().ToString();
            this.Comment = comment;
        }


    }
}
