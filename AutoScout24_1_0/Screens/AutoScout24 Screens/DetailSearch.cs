using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

using static TestImages.AutoScout24;


namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    public partial class DetailSearch
    {
        partial void ConfigureElementProperties()
        {
        }

        [ModelCapability("Search a car")]
        public void SearchCar([DisplayName("Make")] string make, [DisplayName("Model")] string model, [DisplayName("Variant")] string variant)
        {
            MakeDropdownWithSearchbox.SelectValueWithSearch(make);
            ModelDropdownWithSearchbox.SelectValueWithSearch(model);
            VariantTextbox.Enter(variant);
            ResultsButton.Click(App.SearchResults.WaitForAppear);
        }
    }
}