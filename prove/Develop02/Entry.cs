public class Entry
{
    private string _prompt;
    private string _response;
    private int _dateText;
    private string _delimeter;

    public Entry(string prompt, string response, int dateText, string delimeter)
    {
        _prompt = prompt;
        _response = response;
        _dateText = dateText;
        _delimeter = delimeter;

    }
}