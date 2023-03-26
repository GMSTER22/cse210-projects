public class Address
{
  private string _street;
  private string _city;
  private string _stateOrProvince;
  private string _country;

  public Address(string street, string city, string stateOrProvince, string country)
  {
    _street = street;
    _city = city;
    _stateOrProvince = stateOrProvince;
    _country = country;
  }

  public string GetStreet()
  {
    return _street;
  }

  public string GetCity()
  {
    return _city;
  }

  public string GetStateOrProvince()
  {
    return _stateOrProvince;
  }

  public string GetCountry()
  {
    return _country;
  }

  public bool IsNational()
  {
    return _country.ToLower() == "usa";
  }
}