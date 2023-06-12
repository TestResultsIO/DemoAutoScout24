using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

using static TestImages.AutoScout24;


namespace AutoScout24_Model.Screens.TruckScout24Screens.SellWorkflow
{
    public partial class Description
    {
        partial void ConfigureElementProperties()
        {
            CanScrollToFindElement = true;

            VehicleTypeTextbox.TextBoxType = TextBoxType.OCR;
            VehicleTypeTextbox.ClickOutBeforeOCR = false;

            SubstructureDropdown.DropdownListOcrParas.SearchLevel = SearchLevel.Words;
            SubstructureDropdown.DropdownListOcrParas.EnableStartStringAnchor = true;
            SubstructureDropdown.DropdownListOcrParas.EnableEndStringAnchor = true;
        }
    }
}