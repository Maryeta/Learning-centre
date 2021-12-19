using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Admin: Person, IEmployee
    {
        public string Position = "Администратор";
        public int Lab { get; set; }
        public DateTime DatePos { get; set; } 
        public decimal Salary { get; set; } 

        public Admin (string LastName, DateTime BirthDate, int Lab, DateTime DatePos): base(LastName, BirthDate)
        {
            this.Lab = Lab;
            this.DatePos = DatePos;
        }

        public int YearsOfPractic() => DateTime.Today.Year - DatePos.Year;

        public void CalcSalary() //перенаправляем расчет ЗП в класс Count
        {
            Count.CountSalaryAdmin(this);
        }

        public override string ToString() => $"{base.ToString()} \n{Position} - Лаборатория {Lab}, стаж работы: {YearsOfPractic()}\n";
    }
}
