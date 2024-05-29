public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        string displayReference = "";
        if (_endVerse == 0)
        {
            displayReference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else 
        {
            displayReference = $"{_book} {_chapter}:{_startVerse}";
        }

        
    }

    public void DisplayReference(string displayReference)
    {
        Console.WriteLine(displayReference);
    }
}