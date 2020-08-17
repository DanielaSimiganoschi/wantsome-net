using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    class Disciplines : Comment
    {
        public string NameDiscipline { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }
        public string Comment { set; get; }

        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
        {
            this.NameDiscipline = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Disciplines(string name, int numberOfLectures, int numberOfExercises, string comment)
        {
            this.NameDiscipline = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.Comment = comment;
        }

    }
}
