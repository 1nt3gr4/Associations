using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Timeboard
    {
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Timesheet> TimeSheet { get; set; }

        public Timeboard(DateTime sd, DateTime ed, Employee e)
        {
            StartDate = sd;
            EndDate = ed;
            TimeSheet = new List<Timesheet>();
            Employee = e;
        }

        public double Salary()
        {
            double salary = 0;
            
            for(int i = 0; i < TimeSheet.Count; i++)
            {
                double daySalary = 0;
                daySalary = TimeSheet[i].Hours * Employee.HourlyRate;
                if (TimeSheet[i].Date.DayOfWeek == DayOfWeek.Saturday || TimeSheet[i].Date.DayOfWeek == DayOfWeek.Sunday)
                    daySalary *= 2;
                else if (TimeSheet[i].Hours > 8)
                    daySalary += (TimeSheet[i].Hours - 8) * Employee.HourlyRate;
                salary += daySalary;
            }
            return salary;
        }
    }
}
