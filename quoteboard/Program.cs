// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Source source = new Source("1 Nephi 1:1");

Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holland", "Because of Jesus", source);

Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();

quoteboard.AddQuote(holland);
quoteboard.ShowQuotes();
quoteboard.GetRandomQuote();
quoteboard.FindQuotesByAuthor("holland");

Menu menu = new Menu(_board);
_menu.Display();