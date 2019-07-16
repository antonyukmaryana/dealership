using System;
using System.Collections.Generic;
class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Message;

  public Car(string makeModel, int price, int miles, string message)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }

  public bool Drivable(int maxMiles)
  {
    return (Miles < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "bright red");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "dull");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "rusty");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "blue");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);
    int c = CarsMatchingSearch.Count;

    foreach (Car automobile in Cars)
    {
      if ((automobile.WorthBuying(maxPrice)) && (automobile.Drivable(maxMiles)))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
    if (c == 0)
    {
      Console.WriteLine("We have no cars that match your budget constraint");
    }
  }
}
