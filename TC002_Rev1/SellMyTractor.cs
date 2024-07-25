using Progile.TRIO.EnvironmentModel;

[TestCase(1)]
public class SellMyTractor : TestCase
{
    [PreconditionStep(TestInput = @"Make sure the Browser is open")]
    public override void PreconditionStep(ITester t)
    {
        t.Report.PassFailStep(
            App.Browser.WaitForAppear(),
            $@"The screen {/*element*/ App.Browser} was displayed.",
            $@"The element {/*element*/ App.Browser} was not found on the UI.");

    }

    [TestStep(1,
        TestInput = @"Use the Main Menu to go to TruckScout.",
        ExpectedResults = @"The TruckScout Logo is visible and the URL changed to TruckScout24.")]
    public void Step1(ITester t)
    {
        App.Browser.GoToURL($@"https://www.truckscout24.com/");

        //validate the logo changed
        t.Report.PassFailStep(
            App.TruckscoutMainPage.WaitForAppear(),
            $@"The TruckScout Main Page was visible.",
            $@"The TruckScout Main Page was not visible");

        //click away the cookie popup if it is on screen
        t.Optional(() =>
            App.TruckscoutMainPage.AcceptCookies.Click(App.TruckscoutMainPage.AcceptCookies.WaitForDisappear));

    }

    [TestStep(2,
        TestInput = "Start the Sell Workflow.",
        ExpectedResults = "Sell Workflow started, Starts with 1. Vehicle Type.")]
    public void Step2(ITester t)
    {
        App.TruckscoutMainPage.Menu.SelectValueFromSubmenu("Offer", "Advertise vehicle");
        t.Report.PassStep("The Sell workflow was started, the Vehicle Type selection is shown."); //no need to validate again as the line above waited for the VehicleType Screen
    }

    [TestStep(3,
        TestInput = "Select the Vehicle Type 'Agricultural machines'.",
        ExpectedResults = "The workflow navigates to '2. Description', the Vehicle Type is preselected.")]
    public void Step3(ITester t)
    {
        App.VehicleType.AgriculturalMachines.Click(App.Description.WaitForAppear);

        string expectedVehicleType = "Agricultural machines";
        t.Report.PassFailStep(
            App.Description.VehicleTypeTextbox.VerifyText(expectedVehicleType), //the text is verified using ocr because the TextBoxType.OCR was set in the Description Screen Class
            $"The Vehicle Type was preselected as {expectedVehicleType}",
            $"The Vehicle Type was not preselected as {expectedVehicleType}"
        );
    }

    [TestStep(4,
        TestInput = "Enter a Substructure, Make, Model and Description.",
        ExpectedResults = "All values can be entered.")]
    public void Step4(ITester t)
    {
        //scroll down a bit so the dropdowns open downwards and not upwards
        App.Description.Scroller.Scroll(IScroller.Direction.Forward, IScroller.IncrementKind.Small, 3);

        //to make sure more specific Tractors like "Farmyard Tractor" are not selected,
        //string ancors were enabled in the Description Screen Class
        App.Description.SubstructureDropdown.SelectValue("Tractor");

        App.Description.MakeDropdown.SelectValue("Claas");
        App.Description.ModelTextbox.Enter("XERION 5000-4200");

        //take a screenshot, because after this it scrolls down and we can no longer see the values in the report
        t.Testee.TakeScreenshot("Vehicle Data selected"); 

        App.Description.DescriptionTextbox.Enter(@"There is nothing quite like the XERION. You'd recognise it instantly: four equal-sized wheels on two steered axles, full-frame construction for carrying enormous loads, continuously variable transmission up to 530 hp and the intuitive operation that you only get from CLAAS.");
        t.Report.PassStep("Entered all values and verifed the value.");
    }

    [TestStep(5,
        TestInput = @"Upload an Image.",
        ExpectedResults = @"The Image upload completes successfully.")]
    public void Step5(ITester t)
    {
        //follow the guide to setup Supporting Files for the Testcase
        //https://docs.testresults.io/designer/interacting-with-the-sut/tabs-overview/environments/how-to-access-files-on-the-system-under-test
        // create a folder called "SupportingFiles" and copy an image in there named tractor.jpg
        //App.SystemHelpers.SetUpRemoteDirectory(); //open cmd and run this once so the directory is mapped

        App.Description.UploadImageButton.Click(WindowsApp.FileDialog.WaitForAppear);
        WindowsApp.FileDialog.SetFileName(App.SystemHelpers.SupportingFilesDirectory + "tractor.jpg");
        WindowsApp.FileDialog.Open();

        //Search for the Image located in TC002 / Images folder to verify the Upload was successful
        t.Report.PassFailStep(
            t.Testee.FindImage(Images.UploadComplete, TimeSpan.FromMinutes(2)).HasSucceeded,
            "Tractor.jpg uploaded successfully.",
            "Could not upload tractor.jpg."
        );
    }

    [TestStep(6,
        TestInput = @"Switch from new registration to already registered, click continue.",
        ExpectedResults = @"Validations appear that the price, username and password are missing.")]
    public void Step6(ITester t)
    {
        if(!App.Description.AlreadyRegisteredYes.IsActive())
            App.Description.AlreadyRegisteredYes.Click(() => App.Description.AlreadyRegisteredYes.WaitForActive());

        t.Report.PassStep("Switched to already registered.");

        App.Description.ContinueButton.ClickWithUpdateCheck(ImgDiffTolerance.Medium); //we expect to not navigate further but scroll up to Price because it is missing

        t.Report.PassFailStep(
            t.Testee.FindImage(Images.PriceIsARequiredField).HasSucceeded,
            "A red message 'Price is a required field' appeared.",
            "No 'Price is a required field' message appeared."
        );

        App.Description.Scroller.ScrollToEnd();

        t.Report.PassFailStep(
            t.Testee.FindImage(Images.PleaseEnterYourUsername).HasSucceeded,
            "A red message 'Please enter your username' appeared.",
            "No 'Please enter your username' message appeared."
        );

        t.Report.PassFailStep(
            t.Testee.FindImage(Images.PleaseEnterYourPassword).HasSucceeded,
            "A red message 'Please enter your password' appeared.",
            "No 'Please enter your password' message appeared."
        );
    }
}
