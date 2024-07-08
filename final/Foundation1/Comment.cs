class Comment
{
    public string _username;
    public string _text;

    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_username}: \n {_text}");
    }
}