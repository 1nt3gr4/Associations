using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Timesheet
    {
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public Timesheet(DateTime d, int h)
        {
            Date = d;
            Hours = h;
        }
    }
}
