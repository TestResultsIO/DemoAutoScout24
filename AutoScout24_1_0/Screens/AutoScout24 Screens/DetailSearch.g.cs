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
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    [Screen]
    public partial class DetailSearch : Progile.TRIO.BaseModel.BaseScreen
    {
        public DetailSearch(AutoScout24App app) : base(app, @"Detail Search", Images.AutoScout24Screens.DetailSearch.Screen_Loaded)
        {
            App = app;
            MakeDropdownWithSearchbox = new AutoScout24_Model.CustomScreenElements.DropdownWithSearchbox(appBasics: AppBasics, displayName: "Make DropdownWithSearchbox", imageReference: Images.AutoScout24Screens.DetailSearch.MakeDropdown.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            ModelDropdownWithSearchbox = new AutoScout24_Model.CustomScreenElements.DropdownWithSearchbox(appBasics: AppBasics, displayName: "Model DropdownWithSearchbox", imageReference: Images.AutoScout24Screens.DetailSearch.ModelDropdown.DropdownTextBox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            VariantTextbox = new Progile.TRIO.BaseModel.TextBox(appBasics: AppBasics, displayName: "Variant Textbox", imageReference: Images.AutoScout24Screens.DetailSearch.VariantTextbox, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            ResultsButton = new Progile.TRIO.BaseModel.Button(appBasics: AppBasics, displayName: "Results Button", activeImageReference: Images.AutoScout24Screens.DetailSearch.ResultsButton.active, useVisualSense: true, filters: ScreenSelect) { ParentElement = this };
            UsedCheckbox = new Progile.TRIO.BaseModel.LabelWithCheckbox(appBasics: AppBasics, displayName: "Used Checkbox", checkboxPosition: RelativePosition.Left, imageReferenceForLabel: Images.AutoScout24Screens.DetailSearch.UsedCheckbox.LabelImage, checkedImageReference: Images.Common.Checkbox.Checked, uncheckedImageReference: Images.Common.Checkbox.Unchecked, gridWidth: 160, filters: ScreenSelect) { ParentElement = this };
            SeatHeatingCheckbox = new Progile.TRIO.BaseModel.LabelWithCheckbox(appBasics: AppBasics, displayName: "Seat Heating Checkbox", checkboxPosition: RelativePosition.Left, imageReferenceForLabel: Images.AutoScout24Screens.DetailSearch.SeatHeatingCheckbox.LabelImage, checkedImageReference: Images.Common.Checkbox.Checked, uncheckedImageReference: Images.Common.Checkbox.Unchecked, gridWidth: 150, filters: ScreenSelect) { ParentElement = this };
            BodyColorVioletCheckbox = new Progile.TRIO.BaseModel.Checkbox(appBasics: AppBasics, displayName: "Body Color Violet Checkbox", checkedImageReference: Images.AutoScout24Screens.DetailSearch.BodyColorVioletCheckbox._checked, uncheckedImageReference: Images.AutoScout24Screens.DetailSearch.BodyColorVioletCheckbox._unchecked, useVisualSense: false, filters: ScreenSelect) { ParentElement = this };
            CanScrollToFindElement = true;
            UseScreenMonitoringAfterInteraction = true;

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public AutoScout24_Model.CustomScreenElements.DropdownWithSearchbox MakeDropdownWithSearchbox { get; private set; }

        public AutoScout24_Model.CustomScreenElements.DropdownWithSearchbox ModelDropdownWithSearchbox { get; private set; }

        public Progile.TRIO.BaseModel.TextBox VariantTextbox { get; private set; }

        public Progile.TRIO.BaseModel.Button ResultsButton { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithCheckbox UsedCheckbox { get; private set; }

        public Progile.TRIO.BaseModel.LabelWithCheckbox SeatHeatingCheckbox { get; private set; }

        public Progile.TRIO.BaseModel.Checkbox BodyColorVioletCheckbox { get; private set; }

        partial void ConfigureElementProperties();
    }
}