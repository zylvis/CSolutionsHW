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
            if (firstDay < lastDay)
            {
                FirstDay = firstDay;
                LastDay = lastDay;
            }
            else
            {
                throw new ArgumentOutOfRangeException("first day is not less than second day");
            }
            Name = name;
        }

    }
}
