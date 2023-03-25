class ReceptionEvent : Event
{
  private string _email;

  public ReceptionEvent(string email, string title, string description, string street, string city, string stateOrProvince, string country, int year, int month, int day, int hour, int minutes) : base(title, description, street, city, stateOrProvince, country, year, month, day, hour, minutes)
  {
    _email = email;
  }

  public string GetFullDetails()
  {
    string title = GetTitle();
    string description = GetDescription();
    DateOnly date = GetDate();
    TimeOnly time = GetTime();
    string address = GetAddress();

    return $"{title}: {description} \nEmail: {_email} \n{address} \nDate: {date} - {time}";
  }

  public string GetShortDetails()
  {
    string title = GetTitle();
    DateOnly date = GetDate();
    return $"Reception Event: {title} \nDate: {date}";
  }
}