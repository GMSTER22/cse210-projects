class Product
{
  private string _name;
  private int _id;
  private double _price;
  private double _quantity;

  public Product(string name, int id, double price, double quantity)
  {
    _name = name;
    _id = id;
    _price = price;
    _quantity = quantity;
  }

  public string GetName()
  {
    return _name;
  }

  public int GetProductId()
  {
    return _id;
  }

  public double GetPrice()
  {
    return _price * _quantity;
  }
}