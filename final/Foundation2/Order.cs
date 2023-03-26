public class Order
{
  private List<Product> _productList = new List<Product>();
  private Customer _customer;

  public Order(List<Product> productList, Customer customer )
  {
    _productList = productList;
    _customer = customer;
  }

  public double GetOrderTotal()
  {
    double total = 0;
    double nationalShippingFee = 5;
    double nonNationalShippingFee = 35;

    foreach (Product product in _productList)
    {
      total += product.GetPrice();
    }

    if (_customer.IsNational())
    {
      return total + nationalShippingFee;
    } else {
      return total + nonNationalShippingFee;
    }
  }

  public string GetShippingLabel()
  {
    Address address = _customer.GetAddress();
    string street = address.GetStreet();
    string city = address.GetCity();
    string stateOrProvince = address.GetStateOrProvince();
    string country = address.GetCountry();

    return $"{_customer.GetName()}\n{street}\n{city}, {stateOrProvince}, {country}";
  }

  public string GetPackingLabel()
  {
    string label = "";

    for (int i = 0; i < _productList.Count; i++)
    {
      if (i == 0) {
        label += $"{_productList[i].GetProductId()} - $ {_productList[i].GetPrice()}";
      } 
      else
      {
        label += $"\n{_productList[i].GetProductId()} - $ {_productList[i].GetPrice()}";
      }
    }

    return label;
  }
}