using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AutoScout24_Model.Helpers;
using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

using static TestImages.AutoScout24;


namespace AutoScout24_Model.Screens.AutoScout24Screens
{
    public partial class SearchResults
    {
        partial void ConfigureElementProperties()
        {
            OffersFound.ValueOcrParas = OcrParams.TextAlternative;
        }
    }
}