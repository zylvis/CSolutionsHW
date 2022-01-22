using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Catalog
    {
        public List<Book> Book { get; set; }
        public Catalog()
        {
            Book = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Book.Add(book);
        }


    }
}
