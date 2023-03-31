public class Event
{
  private string _title;
  private string _description;
  private DateOnly _date;
  private TimeOnly _time;
  private Address _address;

  public Event(string title, string description, string street, string city, string stateOrProvince, string country, int year, int month, int day, int hour, int minutes)
  {
    _title = title;
    _description = description;
    _date = new DateOnly(year, month, day);
    _time = new TimeOnly(hour, minutes);
    _address = new Address(street, city, stateOrProvince, country);
  }

  public string GetTitle()
  {
    return _title;
  }
  public string GetDescription()
  {
    return _description;
  }
  public DateOnly GetDate()
  {
    return _date;
  }
  public TimeOnly GetTime()
  {
    return _time;
  }
  public string GetAddress()
  {
    return _address.GetAddress();
  }

  public string GetStandardDetails()
  {
    return $"{_title}: {_description} \n{_date} - {_time} \n{_address.GetAddress()}";
  }
}