//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.7.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.TruckScout24Screens.SellWorkflow
{
    [Screen]
    public partial class VehicleType : Progile.TRIO.BaseModel.BaseScreen
    {
        public VehicleType(AutoScout24App app) : base(app, @"Vehicle Type", Images.TruckScout24Screens.SellWorkflow.VehicleType.Screen_Loaded)
        {
            App = app;
            AgriculturalMachines = new Progile.TRIO.BaseModel.Button(tester: t, displayName: "Agricultural machines", activeImageReference: Images.TruckScout24Screens.SellWorkflow.VehicleType.AgriculturalMachines.active, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.Button AgriculturalMachines { get; private set; }

        partial void ConfigureElementProperties();
    }
}