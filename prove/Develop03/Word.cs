public class Word
{
  private string _word;
  private bool _isHidden;

  public Word(string word)
  {
    _word = word;
    _isHidden = false;
  }

  public bool GetIsHidden()
  {
    return _isHidden;
  }

  public string GetWord()
  {
    if (_isHidden)
    {
      List<string> splittedWord = new List<string>();

      foreach (char letter in _word)
      {
        splittedWord.Add("_");
      }

      return string.Join("", splittedWord);
    }

    return _word;
  }

  public void SetIsHidden(bool state)
  {
    _isHidden = state;
  }

  public void SetWord(string word)
  {
    _word = word;
  }

}