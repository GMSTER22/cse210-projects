public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, List<Word> words)
  {
    _reference = reference;
    _words = words;
  }

  private List<Word> filterOutHiddenWords(List<Word> words)
  {
    return words.FindAll( word => word.GetIsHidden() == false);
  }

  public void Display()
  {
    Console.Write($"{_reference.GetReference()} ");

    foreach (Word word in _words)
    {
      Console.Write($"{word.GetWord()} ");
    }
  }

  public void HideWords(int frequency)
  {
    List<Word> filteredWords = filterOutHiddenWords(_words);

    Random random = new Random();

    List<int> randomPicks = new List<int>();

    int numbersToHide;

    if (frequency > filteredWords.Count)
    {
      numbersToHide = filteredWords.Count;
    }
    else if (frequency <= 0)
    {
      numbersToHide = 3;
    }
    else
    {
      numbersToHide = frequency;
    }

    while (randomPicks.Count < numbersToHide)
    {
      int randomNumber = random.Next(filteredWords.Count);
      if (!randomPicks.Contains(randomNumber))
      {
        randomPicks.Add(randomNumber);
      }      
    }    

    for (int i = 0; i < randomPicks.Count; i++)
    {
      filteredWords[randomPicks[i]].SetIsHidden(true);
    }

  }

  public bool IsCompletelyHidden()
  {
    foreach (Word word in _words)
    {
      if (word.GetIsHidden() == false)
      {
        return false;
      }
    }
    return true;
  }

}