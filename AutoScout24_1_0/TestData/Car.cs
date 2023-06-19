using Progile.ATE.Extensions.Excel;
using Progile.ATE.TestFramework;

using System;

namespace AutoScout24_Model.TestData
{
    // Example Usage
    /*
    [TestStep(1)]
    public void Step1(ITester t)
    {
        // Load test data from excel
        var testData = Excel.Load(@"TestData_Cars.xlsx").LoadSheet();

        // get a random car
        var testCar = testData.GetRandom<Car>();
        t.Log($"Car model: {testCar.Make} {testCar.Model}");
        t.Log($"Car age: {DateTime.Now - testCar.FirstRegistration}");

        // get car in row 3
        var testCar5 = testData.GetRow<Car>(3);

        // Run some test for all cars in the excel
        testData.ForAll<Car>((car, _) => PerformTest(car));
    }

    void PerformTest(Car car) { }
    */


    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        [ExcelName("First registration")]
        public DateTime FirstRegistration { get; set; }

        public double Mileage { get; set; }

        public string Gearbox { get; set; }

        [ExcelName("Fuel type")]
        public string FuelType { get; set; }

        public double Power { get; set; }

        [ExcelName("Second hand")]
        public bool SecondHand { get; set; }

    }
}
