class LectureEvent : Event
{
  private string _speaker;
  private int _capacity;

  public LectureEvent(string speaker, int capacity, string title, string description, string street, string city, string stateOrProvince, string country, int year, int month, int day, int hour, int minutes) : base(title, description, street, city, stateOrProvince, country, year, month, day, hour, minutes)
  {
    _speaker = speaker;
    _capacity = capacity;
  }

  public string GetFullDetails()
  {
    string title = GetTitle();
    string description = GetDescription();
    DateOnly date = GetDate();
    TimeOnly time = GetTime();
    string address = GetAddress();

    return $"{title}: {description} \nCapacity: {_capacity} \nSpeaker: {_speaker} \n{address} \nDate: {date} - {time}";
  }

  public string GetShortDetails()
  {
    string title = GetTitle();
    DateOnly date = GetDate();
    return $"Lecture Event: {title} \nDate: {date}";
  }
}