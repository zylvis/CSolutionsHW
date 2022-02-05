using BookTask;

Book book1 = new Book("1234567890134", "Weather", new DateTime(2008, 3, 1), new List<string>() { "Carl"});
Book book2 = new Book("555-4-56-666666-4", "Sky", new DateTime(2003, 9, 30), new List<string>() { "Johhn"});

Catalog catalog = new Catalog();
catalog.AddBook(book1);
catalog.AddBook(book2);

Book bookByISBN1 = catalog.GetBookByISBN("5554566666664");
Book bookByISBN2 = catalog.GetBookByISBN("555-4-56-666666-4");

Console.WriteLine(bookByISBN1.ISBN + " " + bookByISBN1.Title);
Console.WriteLine(bookByISBN2.ISBN + " " + bookByISBN1.Title);


