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

namespace AutoScout24_Model.Screens.TruckScout24Screens.SellWorkflow
{
    [Screen]
    public partial class Description : Progile.TRIO.BaseModel.BaseScreen
    {
        public Description(AutoScout24App app) : base(app, @"Description", Images.TruckScout24Screens.SellWorkflow.Description.Screen_Loaded)
        {
            App = app;
            SubstructureDropdown = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "Substructure Dropdown", imageReference: Images.TruckScout24Screens.SellWorkflow.Description.SubstructureDropdown.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            MakeDropdown = new Progile.TRIO.BaseModel.Dropdown(appBasics: AppBasics, displayName: "Make Dropdown", imageReference: Images.TruckScout24Screens.SellWorkflow.Description.MakeDropdown.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            ModelTextbox = new Progile.TRIO.BaseModel.TextBox(appBasics: AppBasics, displayName: "Model Textbox", imageReference: Images.TruckScout24Screens.SellWorkflow.Description.ModelTextbox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            VehicleTypeTextbox = new Progile.TRIO.BaseModel.TextBox(appBasics: AppBasics, displayName: "Vehicle Type Textbox", imageReference: Images.TruckScout24Screens.SellWorkflow.Description.VehicleType, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            DescriptionTextbox = new Progile.TRIO.BaseModel.TextBox(appBasics: AppBasics, displayName: "Description Textbox", imageReference: Images.TruckScout24Screens.SellWorkflow.Description.DescriptionTextbox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            PriceLabel = new Progile.TRIO.BaseModel.Label(appBasics: AppBasics, displayName: "Price Label", imageReference: Images.TruckScout24Screens.SellWorkflow.Description.PriceLabel, filters: ScreenSelect) { ParentElement = this };
            UploadImageButton = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Upload Image Button", activeImageReference: Images.TruckScout24Screens.SellWorkflow.Description.UploadImageButton.active, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            AlreadyRegisteredYes = new Progile.TRIO.BaseModel.LabelWithButton(appBasics: AppBasics, displayName: "Already Registered Yes", buttonPosition: RelativePosition.Below, imageReferenceForLabel: Images.TruckScout24Screens.SellWorkflow.Description.AlreadyRegisteredYes.LabelImage, buttonActiveimageReference: Images.TruckScout24Screens.SellWorkflow.Description.AlreadyRegisteredYes.Button.active, buttonInactiveImageReference: Images.TruckScout24Screens.SellWorkflow.Description.AlreadyRegisteredYes.Button.inactive, filters: ScreenSelect) { ParentElement = this };
            ContinueButton = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Continue Button", activeImageReference: Images.TruckScout24Screens.SellWorkflow.Description.ContinueButton.active, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            CanScrollToFindElement = true;
            VehicleTypeTextbox.TextBoxType = Progile.TRIO.BaseModel.TextBoxType.OCR;

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.Dropdown SubstructureDropdown { get; private set; }

        public Progile.TRIO.BaseModel.Dropdown MakeDropdown { get; private set; }

        public Progile.TRIO.BaseModel.TextBox ModelTextbox { get; private set; }

        public Progile.TRIO.BaseModel.TextBox VehicleTypeTextbox { get; private set; }

        public Progile.TRIO.BaseModel.TextBox DescriptionTextbox { get; private set; }

        public Progile.TRIO.BaseModel.Label PriceLabel { get; private set; }

        public Progile.TRIO.BaseModel.Button UploadImageButton { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithButton AlreadyRegisteredYes { get; private set; }

        public Progile.TRIO.BaseModel.Button ContinueButton { get; private set; }

        partial void ConfigureElementProperties();
    }
}