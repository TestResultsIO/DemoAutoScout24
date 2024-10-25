[TestCase(1)]
public class RefineSearch : TestCase
{
    [PreconditionStep(TestInput = @"Browser is open with https://www.autoscout24.com/",
        ExpectedResults = @"AutoScout24 Main Page was found")]
    public override void PreconditionStep(ITester t)
    {
        /*
         * if the test is executed on the portal the browser will be opened
         * automatically with the https://www.autoscout24.com/ as it is defined in the Webpage SoftwareModel
         * 
         * if you run this testcase in Visual Studio make sure to connect 
         * to your test environment and open https://www.autoscout24.com/ there in Microsoft Edge
        */
        t.Report.PassFailStep(App.MainPage.WaitForAppear(), $@"The element {/*element*/ App.MainPage} was displayed on the screen.", $@"The element {/*element*/ App.MainPage} was not found on the screen.");
    }

    [TestStep(1,
        TestInput = @"Click the Link 'Refine Search'",
        ExpectedResults = @"The Detail Search Screen opens")]
    public void Step1(ITester t)
    {
        App.MainPage.RefineSearchLink.Click(App.DetailSearch.WaitForAppear);
        t.Report.PassStep($@"The Detail Search Screen is open");
    }


    [TestStep(2,
        TestInput = @"Search for Rolls-Royce Ghost (used, V12, with Seat heating)",
        ExpectedResults = @"Report how many Offers there are")]
    public void Step2(ITester t)
    {
        App.DetailSearch.MakeDropdownWithSearchbox.SelectValueWithSearch($@"Ro", $@"Rolls-Royce");
        App.DetailSearch.ModelDropdownWithSearchbox.SelectValue($@"Ghost");
        App.DetailSearch.AdditionalProperties.Enter($@"V12");
        App.DetailSearch.UsedCheckbox.Check();
        App.DetailSearch.SeatHeatingCheckbox.Check();
        App.DetailSearch.ResultsButton.Click(App.SearchResults.WaitForAppear);
        t.SetVariable("numberOfOffers", App.SearchResults.OffersFound.ReadValue());
        t.ReportVariableValue("{{numberOfOffers}}", "numberOfOffers");
    }
}
