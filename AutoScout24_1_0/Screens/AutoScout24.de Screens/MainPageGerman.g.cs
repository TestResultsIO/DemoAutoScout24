//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.3.2.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.AutoScout24_deScreens
{
    [Screen]
    public partial class MainPageGerman : Progile.TRIO.BaseModel.BaseScreen
    {
        public MainPageGerman(AutoScout24App app) : base(app, @"Main Page German", Images.AutoScout24_deScreens.MainPageGerman.Screen_Loaded)
        {
            App = app;
            KaufenDropdownMenu = new Progile.TRIO.BaseModel.DropdownMenu(appBasics: AppBasics, displayName: "Kaufen Dropdown Menu", imageReference: Images.AutoScout24_deScreens.MainPageGerman.KaufenDropdownMenu.MenuLabel, hoverToExpand: false, opensOnSide: false, filters: ScreenSelect) { ParentElement = this };

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.DropdownMenu KaufenDropdownMenu { get; private set; }

        partial void ConfigureElementProperties();
    }
}