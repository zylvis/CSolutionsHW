using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Catalog : IEnumerable
    {
        private const string isbnPattern1 = "[0-9]{3}-[0-9]-[0-9]{2}-[0-9]{6}-[0-9]";
        private const string isbnPattern2 = "[0-9]{13}";

        private List<(string isbn, Book book)> Books { get; set; }
        public Catalog()
        {
            Books = new List<(string, Book)>();
        }

        public void AddBook(string isbn, Book book)
        {
            Match m1 = Regex.Match(isbn, isbnPattern1);
            Match m2 = Regex.Match(isbn, isbnPattern2);
            if (m1.Success || m2.Success)
            {
                Books.Add((isbn, book));
            }
            else
            {
                throw new Exception("Wrong ISBN number");
            }

        }


        public Book GetBookByISBN(string isbn)
        {

            if (isbn.Length == 13)
            {
                if (Books.FirstOrDefault(x => Regex.Replace(x.isbn, "-", String.Empty) == isbn).isbn == isbn)
                {
                    return Books.FirstOrDefault(x => Regex.Replace(x.isbn, "-", String.Empty) == isbn).book;
                }
                else
                {
                    throw new ArgumentException("No matches.");
                }

            }
            else if (isbn.Length == 17)
            {
                if (Books.FirstOrDefault(x => x.isbn == isbn).isbn == isbn)
                {
                    return Books.FirstOrDefault(x => x.isbn == isbn).book;
                }
                else
                {
                    throw new ArgumentException("No matches.");
                }

            }
            else
            {
                throw new ArgumentException("Wrong ISBN number");
            }


        }

        public IEnumerator GetEnumerator()
        {
            return Books.GetEnumerator();
        }
    }
}
