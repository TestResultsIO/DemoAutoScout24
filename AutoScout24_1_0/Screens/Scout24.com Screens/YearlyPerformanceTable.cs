
using System;
using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;

namespace AutoScout24_Model.Screens.Scout24_comScreens
{
    public partial class YearlyPerformanceTable
    {
        protected override void Initialize()
        {
            //search this label, to have a fix point where the table ends
            var bottomOfTable = App.SharePriceScreen.LabelDataProvided.WaitFor();

            base.Initialize(); //do this second, because to find bottomOfTable we could scroll and change to position of the table 

            Column2023.WaitFor();

            //the TableRect defines where on the screen the Table is
            //"Position Boundary" is where the "Table Loaded Image" was found, in this case the 'Scout24 (XETRA)' column header
            //which can be used as the Top Left Corner of the TableRect
            TableRect = ResultRectangle.FromLTRB(
                left: Position.Boundary.TopLeft.X,
                top: Position.Boundary.TopLeft.Y,
                right: Column2023.Position.Boundary.Right, //only works as we did a "Column2023.WaitFor();" before
                bottom: bottomOfTable.Boundary.Top
            );
        }
    }
}
