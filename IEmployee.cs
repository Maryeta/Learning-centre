using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    interface IEmployee
    {
        DateTime DatePos { get; set; } //дата приема на работу
        int YearsOfPractic(); //стаж работы
        void CalcSalary(); //расчет ЗП
    }
}
