
using System;
using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;

namespace AutoScout24_Model
{
	public partial class YearlyPerformanceTable
	{
		protected override void Initialize()
		{
			base.Initialize();

			Column2023.WaitFor();
			//the TableRect defines where on the screen the Table is
			//"Position Boundary" is where the "Table Loaded Image" was found, in this case the "Scout24 (XETRA" column header)
			//which can be used as the Top Left Corner of the TableRect
			TableRect = ResultRectangle.FromLTRB(
				left: Position.Boundary.TopLeft.X,
				top: Position.Boundary.TopLeft.Y,
				right: Column2023.Position.Boundary.Right, //only works as we did a "Column2023.WaitFor();" before
                bottom: 1150 //where the Browser Ends and the Windows Task Bar starts
			);
		}
	}
}
