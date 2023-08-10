//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.4.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.Scout24_comScreens
{
    [Screen]
    public partial class SharePriceScreen : Progile.TRIO.BaseModel.BaseScreen
    {
        public SharePriceScreen(AutoScout24App app) : base(app, @"Share Price Screen", Images.Scout24_comScreens.SharePriceScreen.Screen_Loaded)
        {
            App = app;
            YearlyPerformanceTab = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Yearly Performance Tab", activeImageReference: Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTab.active, inactiveImageReference: Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTab.inactive, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            YearlyPerformanceTable = new YearlyPerformanceTable(app) { ParentElement = this };

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.Button YearlyPerformanceTab { get; private set; }

        public YearlyPerformanceTable YearlyPerformanceTable { get; private set; }

        partial void ConfigureElementProperties();
    }
}