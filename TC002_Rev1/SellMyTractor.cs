[TestCase(1)]
public class SellMyTractor : TestCase
{
    [PreconditionStep(TestInput = @"Browser is open with https://www.autoscout24.com/",
    ExpectedResults = @"AutoScout24 Main Page was found")]
    public void PreconditionStep(ITester t)
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

    [TestStep(1, TestInput ="Use the Main Menu to go to TruckScout", ExpectedResults = "The TruckScout Logo is visible and the URL changed to TruckScout24")]
    public void Step1(ITester t)
    {
        //Open Menu -> click Trucks
        App.MainMenu.GoToTrucks();

        //validate the logo changed
        t.Report.PassFailStep(
            App.TruckscoutMainPage.WaitForAppear(),
            "The TruckScout Main Page was visible.",
            "The TruckScout Main Page was not visible"
        );

        //validate browser url switched to trucks
        string expectedUrl = "TruckScout24.com";
        t.Report.PassFailStep(
            App.Browser.URLTextBox.GetText().Contains(expectedUrl),
            $"The Browser URL switched to {expectedUrl}",
            $"The Browser URL did not switch to {expectedUrl}"
        );
    }

    [TestStep(2,
            TestInput = "TestInput1",
            ExpectedResults = "ExpectedResult")]
    public void Step2(ITester t)
    {
        //click sell now (the one below because the one on top requires a login?)
        //enter some info
        //click next -> check validation messages (with test case images?)
        t.Report.PassStep("Hello World!");
        t.Report.FailStep("REPLACE_ME");
    }
}
