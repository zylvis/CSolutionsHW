using BookTask;

Book book1 = new Book("123-4-56-789012-3", "Weather", new DateTime(2008, 3, 1), new List<string>());

Catalog catalog = new Catalog();
catalog.AddBook(book1);

foreach (var item in catalog.Books)
{
    Console.WriteLine(item.Date);
}
