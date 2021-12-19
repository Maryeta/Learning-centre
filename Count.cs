using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Count //процедура расчета заработной платы сотрудников
    {
        private static decimal salaryManager = 50000; //фиксированный оклад
        private static decimal salaryEducator = 70000;
        private static decimal salaryAdmin = 40000;

        public Count()
        {
        }
        public static void CountSalaryManager(Manager man)
        {
            decimal coefficient = 2;
            decimal bonus = coefficient * salaryManager / 10;
            decimal finalySalary = salaryManager + bonus;
            man.Salary = finalySalary;
        }

        public static void CountSalaryEducator(Educator ed)
        {
            decimal coefficient = 4;
            decimal bonus = coefficient * salaryEducator / 10 + ed.YearsOfPractic()*500; //зависит от стажа 
            decimal finalySalary = salaryEducator + bonus;
            ed.Salary = finalySalary;
        }

        public static void CountSalaryAdmin( Admin adm)
        {
            decimal coefficient  = 2;
            decimal bonus = coefficient * salaryManager / 10;
            decimal finalySalary = salaryAdmin + bonus;
            adm.Salary = finalySalary;
        }
    }
}
