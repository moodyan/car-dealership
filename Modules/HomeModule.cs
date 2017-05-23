using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add-car.cshtml"];
      Get["/car-collection"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["car-collection.cshtml", allCars];
      };

      Post["/car-added"] = _ => {
        string userMakeModel = Request.Form["make-model"];
        int userPrice = Request.Form["price"];
        int userMiles = Request.Form["miles"];
        Car newCar = new Car(userMakeModel, userPrice, userMiles);
        newCar.Save();
        return View["car-added.cshtml", newCar];
      };

    }
  }
}
