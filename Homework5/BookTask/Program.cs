using BookTask;

Book book1 = new Book("123-4-56-789012-3", "Weather", new DateTime(2008, 3, 1), new List<string>());
Book book2 = new Book("555-4-56-666666-4", "Sky", new DateTime(2003, 9, 30), new List<string>());

Catalog catalog = new Catalog();
catalog.AddBook(book1);
catalog.AddBook(book2);

foreach (var item in catalog)
{
    Console.WriteLine(item.Date + " " +  item.Title);
}


