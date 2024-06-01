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
              
    }

    public void DisplayReference()
    {
        if (_endVerse == 0)
        {
            string displayReference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            Console.WriteLine(displayReference);
        }
        else 
        {
            string displayReference = $"{_book} {_chapter}:{_startVerse}";
            Console.WriteLine(displayReference);
        }
    }
}