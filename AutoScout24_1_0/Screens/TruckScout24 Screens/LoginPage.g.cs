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

namespace AutoScout24_Model.Screens.TruckScout24Screens
{
    [Screen]
    public partial class LoginPage : Progile.TRIO.BaseModel.BaseScreen
    {
        public LoginPage(AutoScout24App app) : base(app, @"Login Page", Images.TruckScout24Screens.LoginPage.Screen_Loaded)
        {
            App = app;
            CustomerNumber = new Progile.TRIO.BaseModel.TextBox(appBasics: AppBasics, displayName: "Customer number", imageReference: Images.TruckScout24Screens.LoginPage.CustomerNumber, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            Password = new Progile.TRIO.BaseModel.PwTextBox(appBasics: AppBasics, displayName: "Password", imageReference: Images.TruckScout24Screens.LoginPage.Password.TextBoxImage, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.TextBox CustomerNumber { get; private set; }

        public Progile.TRIO.BaseModel.PwTextBox Password { get; private set; }

        partial void ConfigureElementProperties();
    }
}