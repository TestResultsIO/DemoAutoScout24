//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.6.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using AutoScout24_Model.Screens.AutoScout24_deScreens;
using AutoScout24_Model.Screens.AutoScout24Screens;
using AutoScout24_Model.Screens.TruckScout24Screens.SellWorkflow;
using AutoScout24_Model.Screens.DemosTelerik;
using AutoScout24_Model.Screens.TruckScout24Screens;
using AutoScout24_Model.Screens.Scout24_comScreens;

namespace AutoScout24_Model
{
    [SoftwareModel]
    public partial class AutoScout24App : IAppBasics
    {
        partial void InitScreens()
        {
            Autohändler = new Autohändler(this);
            CarPreview = new CarPreview(this);
            Description = new Description(this);
            DetailSearch = new DetailSearch(this);
            EditableTableScreen = new EditableTableScreen(this);
            MainMenu = new MainMenu(this);
            MainPageCars = new MainPageCars(this);
            MainPageGerman = new MainPageGerman(this);
            MembersLoginPage = new MembersLoginPage(this);
            SearchResults = new SearchResults(this);
            SharePriceScreen = new SharePriceScreen(this);
            TruckscoutMainPage = new TruckscoutMainPage(this);
            VehicleType = new VehicleType(this);
        }


        public Autohändler Autohändler { get; set; }
        
        public CarPreview CarPreview { get; set; }
        
        public Description Description { get; set; }
        
        public DetailSearch DetailSearch { get; set; }
        
        public EditableTableScreen EditableTableScreen { get; set; }
        
        public MainMenu MainMenu { get; set; }
        
        public MainPageCars MainPageCars { get; set; }
        
        public MainPageGerman MainPageGerman { get; set; }
        
        public MembersLoginPage MembersLoginPage { get; set; }
        
        public SearchResults SearchResults { get; set; }
        
        public SharePriceScreen SharePriceScreen { get; set; }
        
        public TruckscoutMainPage TruckscoutMainPage { get; set; }
        
        public VehicleType VehicleType { get; set; }
        
    }
}