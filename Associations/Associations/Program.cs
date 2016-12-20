using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Position> pos = new List<Position>();
            pos.Add(new Position(1, 100, "Trainee"));
            pos.Add(new Position(2, 150, "Junior Developer"));
            pos.Add(new Position(3, 200, "Middle Developer"));
            pos.Add(new Position(4, 250, "Senior Developer"));
            pos.Add(new Position(5, 300, "Tech Lead"));
            pos.Add(new Position(6, 300, "Team Lead"));
            pos.Add(new Position(7, 500, "Chief Technology Officer"));

            Console.WriteLine("Введите начальную дату табеля: ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечную дату табеля: ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите табельный номер сотрудника: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ФИО сотрудника: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите разряд сотрудника: ");
            int ranking = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату приема на работу: ");
            DateTime empDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Данный сотрудник состоит в профсоюзе? true/false");
            bool isMember = bool.Parse(Console.ReadLine());
            Console.WriteLine("Выберите должность. Доступные должности: ");

            foreach (Position p in pos)
                Console.WriteLine($"{p.Code} - {p.Name}");
            int position = Convert.ToInt32(Console.ReadLine());

            Employee e = new Employee(empDate, fullName, isMember, ranking, number, pos[position]);
            Timeboard timeBoard = new Timeboard(startDate, endDate, e);

            Console.WriteLine("Введите количество рабочих дней: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите дату(рабочий день): ");
                DateTime dt = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество часов: ");
                int hours = int.Parse(Console.ReadLine());
                Timesheet ts = new Timesheet(dt, hours);
                timeBoard.TimeSheet.Add(ts);
            }
            double salary = timeBoard.Salary();
            Console.WriteLine($"Зарплата данного сотрудника составила {salary}.");
        }
    }
}
