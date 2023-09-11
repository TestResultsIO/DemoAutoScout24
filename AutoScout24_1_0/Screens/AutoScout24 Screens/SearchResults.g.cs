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
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    [Screen]
    public partial class SearchResults : Progile.TRIO.BaseModel.BaseScreen
    {
        public SearchResults(AutoScout24App app) : base(app, @"Search Results", Images.AutoScout24Screens.SearchResults.Screen_Loaded)
        {
            App = app;
            OffersFound = new Progile.TRIO.BaseModel.LabelWithValue(tester: t, displayName: "Offers found", valuePosition: RelativePosition.Left, imageReferenceForLabel: Images.AutoScout24Screens.SearchResults.OffersFound, gridWidth: 125, filters: ScreenSelect) { ParentElement = this };
            CanScrollToFindElement = true;
            OffersFound.ValueOcrParas = AutoScout24_Model.Helpers.OcrParams.TextAlternative;

            ConfigureElementProperties();
        }


        private AutoScout24App App { get; set; }
        public Progile.TRIO.BaseModel.LabelWithValue OffersFound { get; private set; }

        partial void ConfigureElementProperties();
    }
}