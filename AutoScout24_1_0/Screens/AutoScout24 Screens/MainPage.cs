using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

using static TestImages.AutoScout24;


namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    public partial class MainPage
    {
        partial void ConfigureElementProperties()
        {
            PriceUpToDropdown.UseCachedPosition = true; //there is no label, only the selected value
        }

        public void SearchCar([DisplayName("Make")] string make, [DisplayName("Model")] string model, [DisplayName("First Registration [Year]")] int firstRegistrationYear)
            => SearchCar(make, model, firstRegistrationYear.ToString());

        [ModelCapability("Search a car")]
        public void SearchCar([DisplayName("Make")] string make, [DisplayName("Model")] string model, [DisplayName("First Registration [Year]")] string firstRegistrationYear)
        {
            Make.SelectValue(make);
            Model.SelectValue(model);
            FirstRegistration.SelectValue(firstRegistrationYear.ToString());

            ResultsButton.Click(ResultsButton.WaitForDisappear);
        }

        [ModelCapability("Verify Car in Search Results")]
        public void VerifyCarInSearchResults(string make, string model, string mileage, string fuelType)
        {
            SearchCar(make, model, $@"");
            App.SearchResults.FindSpecificCarInResults(make, model);

            t.Report.PassFailStep(
                App.CarPreview.Mileage.VerifyValue(mileage, out var actualValue),
                $@"The expected value {/*value*/ $@"mileage"} was shown correctly for {/*element*/ App.CarPreview.Mileage}.",
                $@"The value for {/*element*/ App.CarPreview.Mileage} was {actualValue} instead of the expected value {/*value*/ $@"mileage"}.");

            t.Report.PassFailStep(
                App.CarPreview.FuelType.VerifyValue(fuelType, out actualValue),
                $@"The expected value {/*value*/ $@"fuelType"} was shown correctly for {/*element*/ App.CarPreview.FuelType}.",
                $@"The value for {/*element*/ App.CarPreview.FuelType} was {actualValue} instead of the expected value {/*value*/ $@"fuelType"}.");
        }
    }
}