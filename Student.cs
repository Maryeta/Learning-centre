using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Student: Person
    {
        public string position = "Студент";
        public string Facult { get; set; }
        public int Group { get; set; }

        public Student (string LastName, DateTime BirthDate, string Facult, int Group): base(LastName, BirthDate)
        {
            this.Facult = Facult;
            this.Group = Group;
        }
        public override string ToString() => $"{base.ToString()}\n{position}, факультет {Facult}, группа {Group}\n"; 
    }
}
