using BookTask;

Book book1 = new Book("Weather", new DateTime(2008, 3, 1), new List<string>() { "Carl", "Carl", "Dexter"});
Book book2 = new Book("Sky", new DateTime(2003, 9, 30), new List<string>() { "Johhn"});
Book book3 = new Book("Star", new DateTime(2003, 9, 30), new List<string>() { "Kesha" });
Book book4 = new Book("Thema", new DateTime(2003, 9, 30), new List<string>() { "Pasha" });

Catalog catalog = new Catalog();
catalog.AddBook("1234567891234", book1);
catalog.AddBook("123-4-56-789012-3", book2);
catalog.AddBook("6523562145258", book3);
catalog.AddBook("9635214589524", book4);

Book bookByISBN1 = catalog.GetBookByISBN("1234567891234");
Book bookByISBN2 = catalog.GetBookByISBN("123-4-56-789012-3");

Console.WriteLine(bookByISBN1.Title + " " + bookByISBN1.Authors.First());
Console.WriteLine(bookByISBN2.Title + " " + bookByISBN2.Authors.First());

Console.WriteLine();
Console.WriteLine("All books: ");

Console.WriteLine(catalog.AllBookList());