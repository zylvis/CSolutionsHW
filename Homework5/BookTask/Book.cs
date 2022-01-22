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
            Title = title;
            Date = date;
            Authors = authors;
        }
    }
}
