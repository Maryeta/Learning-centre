using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    abstract class Person
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person (string LastName, DateTime BirthDate)
        {
            this.LastName = LastName;
            this.BirthDate = BirthDate;
        }

        public int DetAge() //определение возраста
        {
            DateTime thisDay = DateTime.Today;
            int age = thisDay.Year - BirthDate.Year;
            if (BirthDate.AddYears(age) > thisDay)
            {
                age--;
            }
            return age;
        }
        public override string ToString() => $"{LastName}, возраст: {DetAge()}";

    }
}
