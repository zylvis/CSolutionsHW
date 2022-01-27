using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacations
{
    internal class Vacation
    {
        public List<Employee> SetOfEmployees { get; set; }
        public Vacation()
        {
            SetOfEmployees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            SetOfEmployees.Add(employee);
        }

        public int GetAverageDaysOfVacations()
        {
            int days = 0;
            TimeSpan date = new TimeSpan(0, 0, 0);

            foreach (Employee item in SetOfEmployees)
            {
                date = item.LastDay - item.FirstDay;
                days = days + date.Days;
            }
            return days / SetOfEmployees.Count;
        }

        public List<(string name, int averageDays)> GetAveregeDaysOfVacationsEach()
        {
            List<(string, int)> daysEach = new List<(string, int)>();
            string? name = null;

            foreach (var item in SetOfEmployees)
            {
                if (item.Name != name)
                {
                    TimeSpan daysSpan = new TimeSpan(0, 0, 0);
                    int days = 0;
                    int averageDays = 0;
                    foreach (var emp in SetOfEmployees.Where(n => n.Name == item.Name))
                    {
                        daysSpan = emp.LastDay - emp.FirstDay;
                        days = days + daysSpan.Days;

                    }
                    daysEach.Add((item.Name, days / SetOfEmployees.Where(n => n.Name == item.Name).Count()));
                }
                name= item.Name;    
            }
            return daysEach.DistinctBy(x => x.Item1).ToList();
        }

        public List<(int month, int empCount)> GetMonthsWithEmployess()
        {
            List<(int, int)> monthsAndNumber = new List<(int, int)>();
            int count = 0;
            for (int i = 1; i <= 12; i++)
            {
                count = SetOfEmployees.Where(x => x.FirstDay.Month == i || x.LastDay.Month == i).DistinctBy(e => e.Name).ToList().Count();
                monthsAndNumber.Add((i, count));
                count = 0;
            }
            return monthsAndNumber;
        }
    }
}
