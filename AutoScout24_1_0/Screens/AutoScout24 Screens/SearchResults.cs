using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        }

        [ModelCapability]
        public void FindSpecificCarInResults(string make, string model)
        {
            var name = $"{make} {model}";
            var carLabel = new Label(App, name, name);
            ScrollToElement(carLabel);
            var select = t.SelectFromColorAtPoint(carLabel.Position);

            // Check if full preview is shown and scroll a bit more if not
            while (select.Bounds.Bottom >= ScreenSelect.Bounds.Bottom)
            {
                Scroller.Scroll(IScroller.Direction.Forward, IScroller.IncrementKind.Small);
                carLabel.IsOnScreen();
                select = t.SelectFromColorAtPoint(carLabel.Position);
            }

            App.CarPreview.InitializeScreenSelect(select);
        }
    }
}