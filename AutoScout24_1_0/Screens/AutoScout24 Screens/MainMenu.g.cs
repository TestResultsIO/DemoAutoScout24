//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.3.5.0
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
    public partial class MainMenu : Progile.TRIO.BaseModel.BaseScreen
    {
        public MainMenu(AutoScout24App app) : base(app, @"Main Menu", Images.AutoScout24Screens.MainMenu.Screen_Loaded)
        {
            App = app;
            MenuButton = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Menu Button", activeImageReference: Images.AutoScout24Screens.MainMenu.MenuButton.active, inactiveImageReference: Images.AutoScout24Screens.MainMenu.MenuButton.inactive, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            UsedAndNewCars = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Used and New Cars", activeImageReference: Images.AutoScout24Screens.MainMenu.UsedAndNewCars.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            Motorbikes = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Motorbikes", activeImageReference: Images.AutoScout24Screens.MainMenu.Motorbikes.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            Trucks = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Trucks", activeImageReference: Images.AutoScout24Screens.MainMenu.Trucks.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            AcceptAllCookies = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Accept All Cookies", activeImageReference: Images.AutoScout24Screens.MainMenu.AcceptAllCookies.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            AcceptAllCookies.WaitTimeInSeconds = 2;

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.Button MenuButton { get; private set; }

        public Progile.TRIO.BaseModel.Button UsedAndNewCars { get; private set; }

        public Progile.TRIO.BaseModel.Button Motorbikes { get; private set; }

        public Progile.TRIO.BaseModel.Button Trucks { get; private set; }

        public Progile.TRIO.BaseModel.Button AcceptAllCookies { get; private set; }

        partial void ConfigureElementProperties();
    }
}