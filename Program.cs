using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var thePerson = new List<Person>
            {
                new Manager("Попова", DateTime.Parse("10,12,1980"), "Информационных технологий", DateTime.Parse("09,06,2012")),
                new Educator("Медведев", DateTime.Parse("12.09.1973"), "Информационных технологий", DateTime.Parse("11.07.2000")),
                new Educator("Орлов", DateTime.Parse("12.09.1980"), "Биотехнологий", DateTime.Parse("18.10.1999")),
                new Student("Краснов",DateTime.Parse("18.07.2000"), "Информационных технологий", 201),
                new Student("Иванов",DateTime.Parse("08.05.2001"), "Информационных технологий", 201),
                new Student("Сидорова",DateTime.Parse("08.12.2001"), "Информационных технологий", 201),
                new Student("Менделеев",DateTime.Parse("25.01.1999"), "Информационных технологий", 202),
                new Student("Миронова",DateTime.Parse("08.10.2000"), "Информационных технологий", 202),
                new Admin ("Петров", DateTime.Parse("15.01.1985"), 7, DateTime.Parse("05.09.2018"))
            };

            foreach (var pers in thePerson)
            {
                Console.WriteLine(pers.ToString());
            }

            Manager manag = new Manager("Попова", DateTime.Parse("10,12,1980"), "Информационных технологий", DateTime.Parse("09,06,2012"));
            manag.CalcSalary();
            Console.WriteLine($"Менеджер {manag.LastName}, Зарплата: {manag.Salary} руб");

            Educator ed = new Educator("Королев", DateTime.Parse("12.09.1973"), "Информационных технологий", DateTime.Parse("11.07.2000"));
            Educator edN = new Educator("Глухарев", DateTime.Parse("12.10.1980"), "Информационных технологий", DateTime.Parse("11.07.2010"));
            ed.CalcSalary();
            Console.WriteLine($"Преподаватель {ed.LastName}, Зарплата: {ed.Salary} руб");
            edN.CalcSalary();
            Console.WriteLine($"Преподаватель {edN.LastName}, Зарплата: {edN.Salary} руб");

            Admin ad = new Admin("Зотов", DateTime.Parse("15.01.1985"), 7, DateTime.Parse("05.09.2018"));
            ad.CalcSalary();
            Console.WriteLine($"Администратор {ad.LastName}, Зарплата: {ad.Salary} руб");


        }
    }
}
