using System.Reflection;

public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentsList = new List<Comment>();

    public Video(string tilte, string author, int leght)
    {
        _title = tilte;
        _author = author;
        _length = leght;
    }
    public int NumberOfComments()
    {
        return _commentsList.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\n{AllComments()}");
    }
    public string AllComments()
    {
        string coment = "";
        foreach (Comment comment in _commentsList)
        {
            coment += comment.CommentText();
        }
        
        return coment;
    } 
    
    public void AddToCommentsList(Comment comment)
    {
        _commentsList.Add(comment);
    }



} 