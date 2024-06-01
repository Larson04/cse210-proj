public class Scripture
{
    private string _verse;
    public List<string> _words = new List<string>();
    public int _randIndex;
    public string _randWord;

    
    public Scripture(string verse)
    {
        _verse = verse;
        _words = verse.Split(" ").ToList();

    }

    public void DisplayScripture()
    {
        string verse = String.Join(" ", _words);
        Console.WriteLine(verse);
    }
    
    public string GetWord()
    {
        _randIndex = new Random().Next(_words.Count);
        string randWord = _words[_randIndex];

        return randWord;
    }

    public void SetWord(string word)
    {
        _randWord = word;
        Words workingWord = new Words();

        int count = 0;
        while (count < 3)
        {
            if (_randWord == "_")
            {
                _words[_randIndex] = _randWord;
                count ++;

            }
            else
            {
                workingWord.SetWord(_randWord);
                _randWord = workingWord.HideWord();
                _words[_randIndex] = _randWord;
            }
        }
        
        
    }


}