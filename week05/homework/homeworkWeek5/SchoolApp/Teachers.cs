using System;
using System.Collections.Generic;
using System.Text;


namespace SchoolApp
{
    class Teachers : People, Comment
    {
        private List<Disciplines> listDisciplines = new List<Disciplines>();

        public string Comment { set; get; }

        public Teachers(string name)
        {
            this.Name = name;
        }
        public Teachers(string name, string nomment)
        {
            this.Name = name;
            this.Comment = nomment;
        }

        public void AddDiscipline(Disciplines discipline)
        {
            listDisciplines.Add(discipline);
        }

    }
}
