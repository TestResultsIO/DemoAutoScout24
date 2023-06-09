//------------------------------------------------------------------------------
//
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.0.0
// Changes to this file may cause incorrect behavior
// and will be lost if the code is regenerated.
// </auto-generated>
//
//------------------------------------------------------------------------------

using System;
using Progile.TRIO.BaseModel;
using Progile.ATE.TestFramework;
using static TestImages.AutoScout24;

namespace AutoScout24_Model
{
	public partial class YearlyPerformanceTable : TableBase<Column, Row>
	{
		public YearlyPerformanceTable(IAppBasics appBasics) : base(appBasics.Tester, "Yearly Performance Table", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.TableLoadedImage)
		{
			Column2023 = new Column(t, "Column2023", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2023, null, TableRect) {ParentElement = this};
			Column2022 = new Column(t, "Column2022", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2022, Column2023, TableRect) {ParentElement = this};
			Column2021 = new Column(t, "Column2021", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2021, Column2022, TableRect) {ParentElement = this};
			Column2020 = new Column(t, "Column2020", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2020, Column2021, TableRect) {ParentElement = this};
			Column2019 = new Column(t, "Column2019", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Column2019, Column2020, TableRect) {ParentElement = this};
			Scout24 = new Column(t, "Scout24", Images.Scout24_comScreens.SharePriceScreen.YearlyPerformanceTable.Scout24, Column2019, TableRect) {ParentElement = this};

			ConfigureElementProperties();
		}

		public Column Scout24;

		public Column Column2019;

		public Column Column2020;

		public Column Column2021;

		public Column Column2022;

		public Column Column2023;

		partial void ConfigureElementProperties();
	}
}
