[TestCase(1)]
public class ScreenElementExampleInteractions : TestCase
{
    /// <summary>
    /// this testcase is not supposed to run
    /// just to show some possible interactions with each Screen Element
    /// </summary>

    // Button Interactions Examples
    [TestStep(1, TestInput ="Button Interactions")]
    public void Step1(ITester t)
    {
        //Each click on a Button requires a Verification
        //if the verification is not fulfilled after 20sec, a retry of the click is automatically performed
        //by default there are 3 tries, but you can configure it with the property "RetryCount" on the Button

        //in most cases this verification is that a new Screen (or element) appears
        App.MainPage.ResultsButton.Click(App.SearchResults.WaitForAppear);

        //or you can also check if an element disappears
        App.MainPage.ResultsButton.Click(App.MainPage.WaitForDisappear);

        //if there is really nothing that appears or disappears you can check that at least the screen updates
        //or write your own customized verification
        App.MainPage.ResultsButton.ClickWithUpdateCheck(ImgDiffTolerance.Medium);

        //if you have a Button with different Active and Inactive states and recorded their Images
        //you can check the current state and depending on it continue on a different path
        if (App.MainPage.ResultsButton.IsActive())
        {
            App.MainPage.ResultsButton.Click(App.SearchResults.WaitForAppear);
        }
        else
        {
            App.MainPage.RefineSearchLink.Click(App.DetailSearch.WaitForAppear);
        }

        //IsActive is the current state, in case you want to verify that it changes the state use WaitForActive / WaitForInactive
        //for example after we selected something in a dropdown, we expect the Button to become active
        App.MainPage.PriceUpToDropdown.SelectValue("5,000");
        t.Report.PassFailStep(
            App.MainPage.ResultsButton.WaitForActive(),
            "The Results Button became active after selecting a price range.",
            "The Results Button was not active after selecting a price range."
        );
    }

    // Checkbox & LabelWithCheckbox Interactions Examples
    [TestStep(2, TestInput = "Checkbox Interactions")]
    public void Step2(ITester t)
    {
        //the Check and Uncheck functions have an included verification
        //based on the "checked" and "unchecked" images you recorded
        App.DetailSearch.BodyColorVioletCheckbox.Check();
        App.DetailSearch.BodyColorVioletCheckbox.Uncheck();

        //and you can also check for the current state
        if (App.DetailSearch.BodyColorVioletCheckbox.IsChecked())
        {

        }

        if (App.DetailSearch.BodyColorVioletCheckbox.IsUnchecked())
        {

        }

        //the same functions exist for LabelWithCheckbox,
        //the difference is just how the Checkbox is searched on the screen
        App.DetailSearch.SeatHeatingCheckbox.Check();
        App.DetailSearch.SeatHeatingCheckbox.Uncheck();

        if (App.DetailSearch.SeatHeatingCheckbox.IsChecked())
        {

        }

        if (App.DetailSearch.SeatHeatingCheckbox.IsUnchecked())
        {

        }
    }

}
