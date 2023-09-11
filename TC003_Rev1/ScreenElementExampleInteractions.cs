[TestCase(1)]
public class ScreenElementExampleInteractions : TestCase
{
    /// <summary>
    /// this testcase is not supposed to run
    /// just to show some possible interactions with each Screen Element
    /// </summary>

    // Button &LabelWithButton Interactions Examples
    [TestStep(1, TestInput ="Button Interactions")]
    public void Step1(ITester t)
    {
        //Each click on a Button requires a Verification
        //if the verification is not fulfilled after 20sec, a retry of the click is automatically performed
        //by default there are 3 tries, but you can configure it with the property "RetryCount" on the Button
        //these examples are from the Main Page of https://www.autoscout24.com/

        //in most cases this verification is that a new Screen (or element) appears
        App.MainPageCars.ResultsButton.Click(App.SearchResults.WaitForAppear);

        //or you can also check if an element disappears
        App.MainPageCars.ResultsButton.Click(App.MainPageCars.WaitForDisappear);

        //if there is really nothing that appears or disappears you can check that at least the screen updates
        //or write your own customized verification
        App.MainPageCars.ResultsButton.ClickWithUpdateCheck(ImgDiffTolerance.Medium);

        //if you have a Button with different Active and Inactive states and recorded their Images
        //you can check the current state and depending on it continue on a different path
        if (App.MainPageCars.ResultsButton.IsActive())
        {
            App.MainPageCars.ResultsButton.Click(App.SearchResults.WaitForAppear);
        }
        else
        {
            App.MainPageCars.RefineSearchLink.Click(App.DetailSearch.WaitForAppear);
        }

        //IsActive is the current state, in case you want to verify that it changes the state use WaitForActive / WaitForInactive
        //for example after we selected something in a dropdown, we expect the Button to become active
        App.MainPageCars.PriceUpToDropdown.SelectValue("5,000");
        t.Report.PassFailStep(
            App.MainPageCars.ResultsButton.WaitForActive(),
            "The Results Button became active after selecting a price range.",
            "The Results Button was not active after selecting a price range."
        );

        //LabelWithButton:
        //use a LabelWithButton if the Button Icon/Image/Text is not unique on the screen, and there is a Label next to it to make it unique
        //the same interactions can be used as with a Button
    }

    // Checkbox & LabelWithCheckbox Interactions Examples
    [TestStep(2, TestInput = "Checkbox Interactions")]
    public void Step2(ITester t)
    {
        //what is the difference between the two elements?
        //Checkbox: if the Checkbox itself is unique on the Screen (the only one, special form or color etc.)
        //LabelWithCheckbox: if a label next to it is required to identify the Checkbox

        //these examples are on the Details Search screen at https://www.autoscout24.com/refinesearch

        //these are examples for a Checkbox:
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

        //the same functions exist for LabelWithCheckbox:
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

    // ContextMenu Interactions Examples
    [TestStep(3, TestInput = "ContextMenu Interactions")]
    public void Step3(ITester t)
    {
        //we use the file explorer as an example with a context menu (the menu that opens on a rightclick)
        App.SystemHelpers.RunProcess("explorer.exe");
        WindowsApp.FileExplorer.WaitFor();
        var position = WindowsApp.FileExplorer.DesktopLabel.WaitFor(); //the position is where we want to right click to open the menu
        WindowsApp.FileExplorer.FileContextMenu.SelectValue(position, "Properties"); //opens the context menu with a rightclick on position and inside the menu selects the "Properties"
        WindowsApp.FileProperties.WaitFor(); //After selecting "Properties" in the context menu, the File Properties open
    }

    //Dropdown & DropdownMenu
    [TestStep(4, TestInput = "Dropdown & DropdownMenu Interactions")]
    public void Step4(ITester t)
    {
        //what is the difference between the two elements?
        //a Dropdown usually consists of a Label and a textbox. With a click into the Textbox the dropdown opens where the possible values can be selected
        //a DropdownMenu does not have this textbox. in practise mostly used for Menus and not for value selections

        //these examples are from the Main Page of https://www.autoscout24.com/
        //Dropdown:
        App.MainPageCars.PriceUpToDropdown.SelectValue("2,500");

        //the dropdown has no label, but only displayes the current value
        //so in the MainPage class file we set "PriceUpToDropdown.UseCachedPosition = true;"
        //so the dropdown can still be used even if "Price up to" is no longer visible
        App.MainPageCars.PriceUpToDropdown.SelectValue("15,000");

        //the german version of the page has Dropdown Menus at the top https://www.autoscout24.de/
        //DropdownMenu:
        App.MainPageGerman.KaufenDropdownMenu.SelectValue("finden");
        App.Autohändler.WaitFor();
    }

    //Scroller
    [TestStep(5, TestInput = "Scroller Interactions")]
    public void Step5(ITester t)
    {
        //the easierst way to enable the scroller is to set "CanScrollToFindElement = true;" on a screen
        //see the DetailsSearch.cs class for an example
        //so if an element is not found immediatly on a screen the scroller is used to find it
        //https://www.autoscout24.com/refinesearch
        App.DetailSearch.BodyColorVioletCheckbox.Check();

        //but you can also scroll manually to an element, using the scroller of the screen
        App.DetailSearch.BodyColorVioletCheckbox.ScrollAndFindElement(App.DetailSearch.Scroller);
        App.DetailSearch.BodyColorVioletCheckbox.Uncheck();

        //Scroll to Top or Bottom of a Page
        App.DetailSearch.Scroller.ScrollToStart();
        App.DetailSearch.Scroller.ScrollToEnd();

        //Scroll up or down
        App.DetailSearch.Scroller.Scroll(
            direction: IScroller.Direction.Forward,       //forward is down, Backward is up
            incrementKind: IScroller.IncrementKind.Large, //small by clicking the arrows,  
            numberOfIncrements: 3
        );
    }

    //Label
    [TestStep(6, TestInput = "Label Interactions")]
    public void Step6(ITester t)
    {
        //a Label is a simple text or image on the screen without interactions

        //https://www.truckscout24.com/members/publish/vehicledata?vt=9
        //You can use it for verifications, if it is on the screen right now
        t.Report.PassFailStep(
            criteria: App.Description.PriceLabel.IsOnScreen(), //checks if the Label is currently on the Screen
            passed: "The Price Label was visible",
            failed: "The Price Label was not visible"
        );

        //Or WaitForIt to appear after some other interaction
        t.Report.PassFailStep(
            criteria: App.Description.PriceLabel.WaitForAppear(), //by default we wait 20sec, change it with PriceLabel.WaitTimeInSeconds
            passed: "The Price Label was visible",
            failed: "The Price Label was not visible"
        );
    }

    //LabelWithValue
    [TestStep(7, TestInput = "Label Interactions")]
    public void Step7(ITester t)
    {
        //The LabelWithValue is used to read some value from the screen
        //the value is hereby identified by some Label on the Screen, the relative position of the value from the label, and a grid width and height
        //in this example we read the value on the left of the "results" button, on how many results are available
        //https://www.autoscout24.com/
        string numberOfResults = App.MainPageCars.NumberOfResultsLabelWithValue.ReadValue();
        bool fourResultsFound = App.MainPageCars.NumberOfResultsLabelWithValue.VerifyValue("4");
        App.MainPageCars.NumberOfResultsLabelWithValue.WaitForValue("4",TimeSpan.FromSeconds(30),out string actualValue);
    }

    //Textbox & PwTextbox
    [TestStep(8, TestInput = "Textbox & PwTextbox Interactions")]
    public void Step8(ITester t)
    {
        //https://www.truckscout24.com/members/login

        //any text already in the Textbox will be deleted
        //the text will be entered and verified with the clipboard (CTRL+C)
        App.MembersLoginPage.UsernameTextbox.Enter("demo");

        //use GetText & VerifyText to get or check the entered Value
        string usernameText = App.MembersLoginPage.UsernameTextbox.GetText();
        bool usernameIsDemo = App.MembersLoginPage.UsernameTextbox.VerifyText("demo");

        //in case the clipboard does not work (for example the textbox is read only) use Optical character recognition (OCR)
        App.MembersLoginPage.UsernameTextbox.TextBoxType = TextBoxType.OCR; //usually set this in Advanced Settings when creating/editing the Textbox
        string usernameTextByOcr = App.MembersLoginPage.UsernameTextbox.GetText();

        //if there is no way to verify what has been entered use EnterWithoutVerification
        App.MembersLoginPage.UsernameTextbox.EnterWithoutVerification("demoNotVerified");

        //the same works for a Password Textbox (capture it as type "PwTextBox")
        //the entered value will be verified by counting the number of Blind Characters found
        App.MembersLoginPage.PasswordTextbox.Enter("demo123");
    }

    //Table
    [TestStep(9, TestInput = "Table Interactions")]
    public void Step9(ITester t)
    {
        //https://www.scout24.com/en/investor-relations/share/share-price


        //to see the Table scroll down and activate the Yearly Performance Tab 
        if (!App.SharePriceScreen.YearlyPerformanceTab.IsActive())
            App.SharePriceScreen.YearlyPerformanceTab.Click(App.SharePriceScreen.YearlyPerformanceTab.WaitForActive);

        //get the row with the value "Yearly Low" in the first Column "Scout24" 
        Row rowYearlyLow = App.SharePriceScreen.YearlyPerformanceTable.GetRow(searchColumn: App.SharePriceScreen.YearlyPerformanceTable.Scout24, "Yearly Low");
        //verify that in this row in column 2020 the value is "45.50"
        bool res1 = App.SharePriceScreen.YearlyPerformanceTable.VerifyCellContent(targetColumn: App.SharePriceScreen.YearlyPerformanceTable.Column2020, rowYearlyLow, "45.50");

        //or both functions in one: verify that the "Yearly Low" of 2020 is "45.50"
        bool res = App.SharePriceScreen.YearlyPerformanceTable.Verify(
            selection: App.SharePriceScreen.YearlyPerformanceTable.Scout24, //column where the "selectionValue" is searched to get the row we are interested in
            selectionValue: "Yearly Low",
            verification: App.SharePriceScreen.YearlyPerformanceTable.Column2020,
            expectedValue: "45.50",
            actualValue: out string actualValue
        );

        //read the value of a cell
        string value = App.SharePriceScreen.YearlyPerformanceTable.GetCellContent(
            targetColumn: App.SharePriceScreen.YearlyPerformanceTable.Column2020,
            targetRow: rowYearlyLow
        );
    }

}
