using AutoScout24_Model.TestData;

using Progile.ATE.Extensions.Excel;

[TestCase(1)]
public class TestdataFromExcel : TestCase
{
    [TestStep(1)]
    public void Step1(ITester t)
    {
        // Load test data from excel
        // Here we load the test data from a file which is included in build output.
        // But excel file with test data could also come from supporting files or other sources.
        var testData = Excel.Load(@"TestData\TestData_Cars.xlsx").LoadSheet();

        // get a random car
        var testCar = testData.GetRandom<Car>();
        t.Log($"Car model: {testCar.Make} {testCar.Model}");

        // use DateTime property of the car
        TimeSpan age = DateTime.Now - testCar.FirstRegistration;
        t.Log($"Car age: {age.Days / 365}");

        // get car in row 3 and search for it in the UI
        var testCar5 = testData.GetRow<Car>(3);
        App.MainPageCars.SearchCar(testCar5.Make, testCar5.Model, testCar5.FirstRegistration.Year);

        // Run some test for all cars in the excel
        testData.ForAll<Car>((car, _) => PerformTest(car, t));
    }


    void PerformTest(Car car, ITester t)
    {
        App.DetailSearch.SearchCar(car.Make, car.Model, "");

        // Verify Details of first car in results:
        App.SearchResults.FindSpecificCarInResults($"{car.Make} {car.Model}");

        t.Report.PassFailStep(
            App.CarPreview.Mileage.VerifyValue(car.Mileage.ToString(), out string actualMileage),
            $"Mileage was shown correctly as {car.Mileage}",
            $"Mileage was shown incorrectly as {actualMileage} instead of {car.Mileage}");

        t.Report.PassFailStep(
            App.CarPreview.FuelType.VerifyValue(car.FuelType, out string actualFuelType),
            $"Fuel type was shown correctly as {car.FuelType}",
            $"Fuel type was shown incorrectly as {actualFuelType} instead of {car.FuelType}");
    }
}
