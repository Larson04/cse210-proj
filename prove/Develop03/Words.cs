public class Words
{
    private string _word;
    public bool _isHidden;


    public void SetWord(string word)
    {
        _word = word;
        if (_word == "_")
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }

    }

    public string HideWord()
    {
        if (_isHidden == false)
        {
            string word = new string('_', _word.Length);
            Console.WriteLine(word);
            return word;
        }
        else{
            return _word;
        }
    }

}