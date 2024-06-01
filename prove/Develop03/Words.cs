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
            return word;
        }
        else{
            return _word;
        }
    }

    public int CheckIfHidden()
    {
        if (_word == string.Concat(Enumerable.Repeat('_', _word.Length)))
        {
            _isHidden = true;
            return 1;
        }
        
        else
        {
            _isHidden = false;
            return 0;
        }

    }
}