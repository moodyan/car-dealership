using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _carDescription = new List<Car> {};


    public Car (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public static List<Car> GetAll()
    {
      return _carDescription;
    }
    public void Save()
    {
      _carDescription.Add(this);
    }
    public static void ClearAll()
    {
      _carDescription.Clear();
    }
  }
}
