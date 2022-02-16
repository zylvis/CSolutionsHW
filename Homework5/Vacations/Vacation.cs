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

        public double GetAverageDaysOfVacations()
        {
            return SetOfEmployees.Average(x => (x.LastDay - x.FirstDay).Days);
        }

        public IEnumerable<(string name, double averageDays)> GetAveregeDaysOfVacationsEach()
        {
            var result = SetOfEmployees
                .GroupBy(x => x.Name).Select(gr => (gr.Key, gr.Average(e => (e.LastDay - e.FirstDay).TotalDays)));

            return result;
        }

        public List<(int month, int empCount)> GetNumberEachMonth()
        {
            List<(int, int)> monthsAndNumber = new List<(int, int)>();
            int count = 0;
            for (int i = 1; i <= 12; i++)
            {
                count = SetOfEmployees.Where(x => x.FirstDay.Month <= i && x.LastDay.Month >= i).DistinctBy(e => e.Name).ToList().Count();
                monthsAndNumber.Add((i, count));
            }
            return monthsAndNumber;
        }

        public List<(int month, int day)> GetFreeDates()
        {
            List<DateTime> allDates = new List<DateTime>();
            List<DateTime> allOcupiedDates = new List<DateTime>();
            List<(int, int)> freeMonthAndDay = new List<(int, int)>();

            for (var i = new DateTime(2021, 1, 1); i <= new DateTime(2021, 12, 31); i = i.AddDays(1))
            {
                allDates.Add(i);
            }

            foreach (var emp in SetOfEmployees)
            {
                for (var i = emp.FirstDay; i <= emp.LastDay; i = i.AddDays(1))
                {
                    if (!allOcupiedDates.Contains(i))
                    {
                        allOcupiedDates.Add(i);
                    }

                }
            }

            allOcupiedDates.Sort();

            foreach (var item in allDates)
            {
                int count = 0;
                foreach (var date in allOcupiedDates)
                {
                    if (item == date)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    freeMonthAndDay.Add((item.Month, item.Day));
                }
            }

            return freeMonthAndDay;
        }

        public bool PersonDatesIntersect()
        {
            int count = 0;
            foreach (var item in SetOfEmployees.GroupBy(x => x.Name).Where(y => y.Count() > 1).ToList())
            {
                var vacations = SetOfEmployees.Where(x => x.Name == item.Key).ToList();

                for (int i = 0; i < vacations.Count; i++)
                {
                    for (int j = i + 1; j < vacations.Count; j++)
                    {
                        if (vacations[i].LastDay >= vacations[j].FirstDay && vacations[i].FirstDay <= vacations[j].LastDay)
                        {
                            count++;
                        }
                    }
                }
            }
            return count > 0;
        }
    }
}
