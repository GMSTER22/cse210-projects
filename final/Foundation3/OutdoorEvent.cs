class OutdoorEvent : Event
{
  private string _weather;

  public OutdoorEvent(string weather, string title, string description, string street, string city, string stateOrProvince, string country, int year, int month, int day, int hour, int minutes) : base(title, description, street, city, stateOrProvince, country, year, month, day, hour, minutes)
  {
    _weather = weather;
  }

  public string GetFullDetails()
  {
    string title = GetTitle();
    string description = GetDescription();
    DateOnly date = GetDate();
    TimeOnly time = GetTime();
    string address = GetAddress();

    return $"{title}: {description} \nWeather: {_weather} \n{address} \nDate: {date} - {time}";
  }

  public string GetShortDetails()
  {
    string title = GetTitle();
    DateOnly date = GetDate();
    return $"Outdoor Event: {title} \nDate: {date}";
  }
}