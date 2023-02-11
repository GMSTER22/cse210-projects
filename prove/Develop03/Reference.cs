public class Reference
{
  private string _book;
  private int _chapter;
  private int _startVerse;
  private int _finalVerse;

  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = verse;
  }

  public Reference(string book, int chapter, int startVerse, int finalVerse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _finalVerse = finalVerse;
  }

  public string GetReference()
  {
    if (string.IsNullOrEmpty(_finalVerse.ToString()))
    {
      return $"{_book} {_chapter}:{_startVerse}";
    }
    else
    {
      return $"{_book} {_chapter}:{_startVerse}-{_finalVerse}";
    }
  }

}