using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
        public List<string>? Authors { get; set; }

        public Book(string isbn, string title, DateTime date, List<string> authors)
        {

            ISBN = isbn;

            if (title == string.Empty || title == null)
            {
                throw new ArgumentException("Title cannot be enpty or null");
            }
            else
            {
                Title = title;
            }

            Date = date;
            Authors = (List<string>)authors.DistinctBy(x => x).ToList();
        }
    }
}
