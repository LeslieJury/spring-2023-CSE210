public class Entry
{
    private string _author = "";
    private string _entry = "";
    private Source _source;

    public Entry(string person, string entry, Source source)
    {
        _author = person;
        _entry = entry;
        _source = source;

    }

    public bool HasAuthor(string name)
    {
        if(_author.ToUpper(). Contains(name.ToUpper()))
        {
            return true;

        }
        return false;
    }

    public string GetEntry()
    {
        return $"\"{_entry}\"\n{_author} - {_source.Stringify()}";

    }



}