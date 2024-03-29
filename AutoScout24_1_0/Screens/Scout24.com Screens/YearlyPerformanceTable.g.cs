//------------------------------------------------------------------------------
//
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.3.5.0
// Changes to this file may cause incorrect behavior
// and will be lost if the code is regenerated.
// </auto-generated>
//
//------------------------------------------------------------------------------

using System;
using Progile.TRIO.BaseModel;
using Progile.ATE.TestFramework;
using static TestImages.AutoScout24;

namespace AutoScout24_Model.Screens.Scout24_comScreens
{
	[Table]
	public partial class YearlyPerformanceTable : TableBase<Column, Row>
	{
		public YearlyPerformanceTable(AutoScout24App app) : base(app, "Yearly Performance Table", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.TableLoadedImage)
		{
			App = app;
			Column2023 = new Column(app, "Column2023", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2023, null, TableRect) {ParentElement = this};
			Column2022 = new Column(app, "Column2022", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2022, Column2023, TableRect) {ParentElement = this};
			Column2021 = new Column(app, "Column2021", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2021, Column2022, TableRect) {ParentElement = this};
			Column2020 = new Column(app, "Column2020", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2020, Column2021, TableRect) {ParentElement = this};
			Column2019 = new Column(app, "Column2019", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2019, Column2020, TableRect) {ParentElement = this};
			Scout24 = new Column(app, "Scout24", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Scout24, Column2019, TableRect) {ParentElement = this};

			ConfigureElementProperties();
		}

		private AutoScout24App App;

		[ModelCapability]
		public Column Scout24 { get; private set; }

		[ModelCapability]
		public Column Column2019 { get; private set; }

		[ModelCapability]
		public Column Column2020 { get; private set; }

		[ModelCapability]
		public Column Column2021 { get; private set; }

		[ModelCapability]
		public Column Column2022 { get; private set; }

		[ModelCapability]
		public Column Column2023 { get; private set; }

		partial void ConfigureElementProperties();
	}
}
