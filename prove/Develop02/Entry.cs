public class Entry
{

  public string _prompt;
  public string _response;
  public DateTime _date;

  public Entry( DateTime date, string prompt, string response )
  {

    _prompt = prompt;

    _response = response;

    _date = date;

  }

  public string GetEntry()
  {

    return $"{_date}##{_prompt}##{_response}";

  }

  public void Display()
  {

    Console.WriteLine($"Date: {_date} - Prompt: {_prompt} \n   {_response}");

  }

} 