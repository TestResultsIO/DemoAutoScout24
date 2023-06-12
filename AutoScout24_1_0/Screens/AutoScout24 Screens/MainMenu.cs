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
    public partial class MainMenu
    {
        private AutoScout24App _app;

        partial void ConfigureElementProperties()
        {
            _app = (AutoScout24App)AppBasics;
        }

        [ModelCapability("Go To Trucks")]
        public void GoToTrucks()
        {
            OpenMenu();
            Trucks.Click(_app.TruckscoutMainPage.WaitForAppear); //NOTE: to make this verification work, the _app Propertie on Line 19 and the ConfigureElementProperties method are required
        }

        [ModelCapability("Open Menu")]
        public void OpenMenu()
        {
            if (MenuButton.IsActive())                        //the "active"   image of the Button is where it is closed
                MenuButton.Click(MenuButton.WaitForInactive); //the "inactive" image of the Button is where it is open
        }
    }
}