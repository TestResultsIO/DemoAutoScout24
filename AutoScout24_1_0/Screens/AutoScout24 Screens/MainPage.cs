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


namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    public partial class MainPage
    {
        partial void ConfigureElementProperties()
        {
            PriceUpToDropdown.UseCachedPosition = true; //there is no label, only the selected value
        }
    }
}