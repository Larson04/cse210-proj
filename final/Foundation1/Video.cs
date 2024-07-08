using System.Transactions;

class Video
{
    public string _title;
    public string _creator;
    public int _length;
    public List<Comment> _commentSection = new List<Comment>();

    public Video(string title, string creator, int length)
    {
        _title = title;
        _creator = creator;
        _length = length;
    }

    public void CommentCount()
    {
        int commentCount = _commentSection.Count;
        Console.WriteLine($"This video has {commentCount} comments.");
    }

    public void AddComment(Comment comment)
    {
        _commentSection.Add(comment);
    }
}