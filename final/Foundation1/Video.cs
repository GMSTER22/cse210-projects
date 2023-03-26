public class Video
{
  public string _title;
  public string _author;
  public int _length;
  public List<Comment> _comments = new List<Comment>();

  public int GetNumberOfComments()
  {
    return _comments.Count;
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }
}