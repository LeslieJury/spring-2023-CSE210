// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Loanable book1 = new Loanable();
book1.CheckOut();
book1.Display();

Dvd dvd1 = new Dvd("Finding Nemo");
dvd1.CheckOut();
dvd1.Display();

Book findingDory = new Book("Finding Dory", "987-100000", 2342323);