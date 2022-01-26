using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Catalog : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }
        public Catalog()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Book GetBookISBN(string isbn)
        {
            if (isbn.Length == 13)
            {
                return Books.FirstOrDefault(x => Regex.Replace(x.ISBN, "-", "") == isbn);
            }
            else if (isbn.Length == 17)
            {
                return Books.FirstOrDefault(x => x.ISBN == isbn);
            }
            else
            {
                throw new ArgumentException("Wrong ISBN number");
            }


        }

    }
}
