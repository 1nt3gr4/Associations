using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Employee
    {
        public Position Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string FullName { get; set; }
        public bool IsMemberOfLaborUnion { get; set; }
        public int Rating { get; set; }
        public int Number;
        public double HourlyRate { get; set; }

        public Employee(DateTime dt, string name, bool m, int r, int n, Position p)
        {
            EmploymentDate = dt;
            FullName = name;
            IsMemberOfLaborUnion = m;
            Rating = r;
            Number = n;
            Position = p;
            HourlyRate = Position.BaseHourlyRate * (1 + Rating * 0.1);
        }
    }
}
