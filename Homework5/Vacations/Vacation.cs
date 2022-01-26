using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacations
{
    internal class Vacation
    {
        public List<object> SetOfEmployees { get; set; }
        public Vacation()
        {
            SetOfEmployees = new List<object>();
        }

        public void Add(object employee)
        {
            SetOfEmployees.Add(employee);
        }
    }
}
