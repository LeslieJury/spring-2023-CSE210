public class Book : Loanable
{
    private string _isbn;
    private int _upc;

    public Book(string title, string isbn, int upc)
    {
        _isbn = isbn;
        _title = title;
        _upc = upc;
    }
/*
    public void ShowBookDetails()
    {
        Console.WriteLine($"{_title} : {_isbn} :: {_upc}");
    }
    */
    public override void Display()
    {
        //ShowBookDetails();
        base.Display();
    }


}