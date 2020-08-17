using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    class School
    {
      private  List<Classes> listClasses = new List<Classes>();
  
        public School()
        {
       
        }

        public void AddClasses( Classes classSchool) {
            listClasses.Add(classSchool);
        }

    }
}
