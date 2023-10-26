//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.6.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using AutoScout24_Model.Screens.AutoScout24Screens;
using AutoScout24_Model.Screens.TruckScout24Screens;
using AutoScout24_Model.Screens.TruckScout24Screens.SellWorkflow;
using AutoScout24_Model.Screens.AutoScout24_deScreens;
using AutoScout24_Model.Screens.Scout24_comScreens;
using AutoScout24_Model.Screens.DemosTelerik;

namespace AutoScout24_Model
{
    public partial class AutoScout24App : IAppBasics
    {
        partial void InitScreens()
        {
            MainPageCars = new MainPageCars(this);
            DetailSearch = new DetailSearch(this);
            SearchResults = new SearchResults(this);
            MainMenu = new MainMenu(this);
            TruckscoutMainPage = new TruckscoutMainPage(this);
            VehicleType = new VehicleType(this);
            Description = new Description(this);
            CarPreview = new CarPreview(this);
            MainPageGerman = new MainPageGerman(this);
            Autohändler = new Autohändler(this);
            MembersLoginPage = new MembersLoginPage(this);
            SharePriceScreen = new SharePriceScreen(this);
            EditableTableScreen = new EditableTableScreen(this);
        }


        public MainPageCars MainPageCars { get; set; }
        
        public DetailSearch DetailSearch { get; set; }
        
        public SearchResults SearchResults { get; set; }
        
        public MainMenu MainMenu { get; set; }
        
        public TruckscoutMainPage TruckscoutMainPage { get; set; }
        
        public VehicleType VehicleType { get; set; }
        
        public Description Description { get; set; }
        
        public CarPreview CarPreview { get; set; }
        
        public MainPageGerman MainPageGerman { get; set; }
        
        public Autohändler Autohändler { get; set; }
        
        public MembersLoginPage MembersLoginPage { get; set; }
        
        public SharePriceScreen SharePriceScreen { get; set; }
        
        public EditableTableScreen EditableTableScreen { get; set; }
        
    }
}