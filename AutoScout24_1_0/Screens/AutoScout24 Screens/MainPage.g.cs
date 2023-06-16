//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.0.0
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
        public MainPage(IAppBasics appBasics) : base(appBasics, @"Main Page", Images.AutoScout24Screens.MainPage.Screen_Loaded)
        {
            RefineSearchLink = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Refine search Link", activeImageReference: Images.AutoScout24Screens.MainPage.RefineSearchLink.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            ResultsButton = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "ResultsButton", activeImageReference: Images.AutoScout24Screens.MainPage.ResultsButton.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            PriceUpToDropdown = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "PriceUpToDropdown", imageReference: Images.AutoScout24Screens.MainPage.PriceUpToDropdown.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };

            ConfigureElementProperties();
        }


        public Progile.TRIO.BaseModel.Button RefineSearchLink { get; private set; }

        public Progile.TRIO.BaseModel.Button ResultsButton { get; private set; }

        public Progile.TRIO.BaseModel.Dropdown PriceUpToDropdown { get; private set; }

        partial void ConfigureElementProperties();
    }
}