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
        private List<Book> Books { get; set; }
        public Catalog()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Match m1 = Regex.Match(book.ISBN, "[0-9]{3}-[0-9]-[0-9]{2}-[0-9]{6}-[0-9]");
            Match m2 = Regex.Match(book.ISBN, "[0-9]{13}");
            if (m1.Success || m2.Success)
            {
                Books.Add(book);
            }
            else
            {
                throw new Exception("Wrong ISBN number");
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Book GetBookByISBN(string isbn)
        {
            if (isbn.Length == 13)
            {
                return Books.FirstOrDefault(x => Regex.Replace(x.ISBN, "-", String.Empty) == isbn);
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
