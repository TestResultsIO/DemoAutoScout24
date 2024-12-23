//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.9.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    [Screen]
    public partial class MainPage : Progile.TRIO.BaseModel.BaseScreen
    {
        public MainPage(AutoScout24App app) : base(app, @"Main Page", Images.AutoScout24Screens.MainPage.Screen_Loaded)
        {
            App = app;
            RefineSearchLink = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Refine search Link", activeImageReference: Images.AutoScout24Screens.MainPage.RefineSearchLink.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            ResultsButton = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "ResultsButton", activeImageReference: Images.AutoScout24Screens.MainPage.ResultsButton.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            PriceUpToDropdown = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "PriceUpToDropdown", imageReference: Images.AutoScout24Screens.MainPage.PriceUpToDropdown.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            Make = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "Make", imageReference: Images.AutoScout24Screens.MainPage.Make.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            Model = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "Model", imageReference: Images.AutoScout24Screens.MainPage.Model.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            FirstRegistration = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "First registration", imageReference: Images.AutoScout24Screens.MainPage.FirstRegistration.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            AcceptAllCookies = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Accept All Cookies", activeImageReference: Images.AutoScout24Screens.MainPage.AcceptAllCookies.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            NumberOfResultsLabelWithValue = new Progile.TRIO.BaseModel.LabelWithValue(appBasics: AppBasics, displayName: "NumberOfResultsLabelWithValue", valuePosition: RelativePosition.Left, imageReferenceForLabel: Images.AutoScout24Screens.MainPage.ResultsButton.active, filters: ScreenSelect) { ParentElement = this };
            Language = new Progile.TRIO.BaseModel.DropdownMenu(appBasics: AppBasics, displayName: "Language", imageReference: Images.AutoScout24Screens.MainPage.Language.MenuLabel, hoverToExpand: false, opensOnSide: false, filters: ScreenSelect) { ParentElement = this };
            CurrentlyInDemand = new Progile.TRIO.BaseModel.Label(appBasics: AppBasics, displayName: "Currently in demand", imageReference: Images.AutoScout24Screens.MainPage.CurrentlyInDemand, filters: ScreenSelect) { ParentElement = this };
            ResultsButtonContextMenu = new Progile.TRIO.BaseModel.ContextMenu(appBasics: AppBasics, displayName: "Results Button Context Menu", imageReference: Images.AutoScout24Screens.MainPage.ResultsButton.active) { ParentElement = this };
            AcceptAllCookies.WaitTimeInSeconds = 2;

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.Button RefineSearchLink { get; private set; }

        public Progile.TRIO.BaseModel.Button ResultsButton { get; private set; }

        public Progile.TRIO.BaseModel.Dropdown PriceUpToDropdown { get; private set; }

        public Progile.TRIO.BaseModel.Dropdown Make { get; private set; }

        public Progile.TRIO.BaseModel.Dropdown Model { get; private set; }

        public Progile.TRIO.BaseModel.Dropdown FirstRegistration { get; private set; }

        public Progile.TRIO.BaseModel.Button AcceptAllCookies { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithValue NumberOfResultsLabelWithValue { get; private set; }

        public Progile.TRIO.BaseModel.DropdownMenu Language { get; private set; }

        public Progile.TRIO.BaseModel.Label CurrentlyInDemand { get; private set; }

        public Progile.TRIO.BaseModel.ContextMenu ResultsButtonContextMenu { get; private set; }

        partial void ConfigureElementProperties();
    }
}