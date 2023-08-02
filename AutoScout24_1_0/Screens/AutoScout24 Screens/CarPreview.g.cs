//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.3.0
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
    public partial class CarPreview : Progile.TRIO.BaseModel.BaseScreen
    {
        public CarPreview(AutoScout24App app) : base(app, @"Car Preview", Images.AutoScout24Screens.CarPreview.Screen_Loaded)
        {
            App = app;
            Mileage = new Progile.TRIO.BaseModel.LabelWithValue(tester: t, displayName: "Mileage", valuePosition: RelativePosition.Right, imageReferenceForLabel: Images.AutoScout24Screens.CarPreview.Mileage, gridWidth: 120, filters: ScreenSelect) { ParentElement = this };
            Gearbox = new Progile.TRIO.BaseModel.LabelWithValue(tester: t, displayName: "Gearbox", valuePosition: RelativePosition.Right, imageReferenceForLabel: Images.AutoScout24Screens.CarPreview.Gearbox, gridWidth: 120, filters: ScreenSelect) { ParentElement = this };
            FirstRegistration = new Progile.TRIO.BaseModel.LabelWithValue(tester: t, displayName: "First Registration", valuePosition: RelativePosition.Right, imageReferenceForLabel: Images.AutoScout24Screens.CarPreview.FirstRegistration, gridWidth: 120, filters: ScreenSelect) { ParentElement = this };
            FuelType = new Progile.TRIO.BaseModel.LabelWithValue(tester: t, displayName: "Fuel Type", valuePosition: RelativePosition.Right, imageReferenceForLabel: Images.AutoScout24Screens.CarPreview.FuelType, gridWidth: 120, filters: ScreenSelect) { ParentElement = this };
            Power = new Progile.TRIO.BaseModel.LabelWithValue(tester: t, displayName: "Power", valuePosition: RelativePosition.Right, imageReferenceForLabel: Images.AutoScout24Screens.CarPreview.Power, gridWidth: 120, filters: ScreenSelect) { ParentElement = this };

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.LabelWithValue Mileage { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithValue Gearbox { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithValue FirstRegistration { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithValue FuelType { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithValue Power { get; private set; }

        partial void ConfigureElementProperties();
    }
}