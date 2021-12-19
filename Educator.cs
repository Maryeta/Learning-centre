using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Educator: Person, IEmployee
    {
        public string Position = "Преподаватель";
        public string Facult { get; set; }
        public DateTime DatePos { get; set; } 
        public decimal Salary { get; set; } 
        public decimal Bonus { get; set; } 

        public Educator (string LastName, DateTime BirthDate, string Facult, DateTime DatePos): base(LastName, BirthDate)
        {
            this.Facult = Facult;
            this.DatePos = DatePos;
        }

        public int YearsOfPractic() => DateTime.Today.Year - DatePos.Year;

        public void CalcSalary() //перенаправляем расчет ЗП в класс Count
        {
            Count.CountSalaryEducator(this);
        }

        public override string ToString() => $"{base.ToString()} \n{Position} - Факультет {Facult}, стаж работы: {YearsOfPractic()} \n";
    }
}
