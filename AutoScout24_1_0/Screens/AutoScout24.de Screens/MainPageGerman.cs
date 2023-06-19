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


namespace AutoScout24_Model.Screens.AutoScout24_deScreens
{
	public partial class MainPageGerman
	{
        partial void ConfigureElementProperties()
        {
            KaufenDropdownMenu.ToleranceForDetectChanges = 0.01; //with the default value of 0.04 the bottom part was ignored as the background color before is the same
        }
    }
}