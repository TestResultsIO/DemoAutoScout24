using AutoScout24_Model.TestData;

using Progile.ATE.Extensions.Excel;
using TC004_Rev1.TestData;

[TestCase(1)]
public class TestdataFromExcel : TestCase
{
    public TestData_Cars TestCars { get; private set; }

    [SetupTest]
    public override bool Setup(ITester t)
    {
        TestCars =  TestData_Cars.LoadTestDataIntoVariables(t);
        return base.Setup(t);
    }

    [TestStep(1)]
    public void Step1(ITester t)
    {
        // get car in the selected row and search for it in the UI (selected row can be set in Variable dialog, on portal run corresponds to instance number)
        App.MainPage.SearchCar("{{TestData_Cars:Make}}", "{{TestData_Cars:Model}}", "{{TestData_Cars:FirstRegistration}}");


        // Run some interaction for all cars in the excel
        TestData_Cars.ForAll((testData) =>
            App.MainPage.VerifyCarInSearchResults(testData.Make, testData.Model, testData.Mileage, testData.FuelType));

    }


    [TestStep(2)]
    public void Step2(ITester t)
    {
        // You can also work with excel data in code, which gives you more flexibility

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
        App.MainPage.SearchCar(testCar5.Make, testCar5.Model, testCar5.FirstRegistration.Year);

        // Run some test for all cars in the excel
        testData.ForAll<Car>((car, _) => PerformTest(car, t));
    }


    void PerformTest(Car car, ITester t)
    {
        App.DetailSearch.SearchCar(car.Make, car.Model, "");

        // Verify Details of first car in results:
        App.SearchResults.FindSpecificCarInResults(car.Make, car.Model);

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
