using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacations
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        public Employee(string name, DateTime firstDay, DateTime lastDay)
        {
            Name = name;
            FirstDay = firstDay;
            LastDay = lastDay;

        }


    }
}
