//------------------------------------------------------------------------------
//
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.9.0.0
// Changes to this file may cause incorrect behavior
// and will be lost if the code is regenerated.
// </auto-generated>
//
//------------------------------------------------------------------------------

using System;
using Progile.ATE.Extensions.Excel;

namespace TC004_Rev1.TestData
{
	[ExcelName("TestData_Cars.xlsx")]
	public partial class TestData_Cars
	{
		public static int SelectedRow = 2;
		[ExcelName("Make")]
		public string Make { get; private set; }

		[ExcelName("Model")]
		public string Model { get; private set; }

		[ExcelName("Price")]
		public string Price { get; private set; }

		[ExcelName("First registration")]
		public string FirstRegistration { get; private set; }

		[ExcelName("Mileage")]
		public string Mileage { get; private set; }

		[ExcelName("Gearbox")]
		public string Gearbox { get; private set; }

		[ExcelName("Fuel type")]
		public string FuelType { get; private set; }

		[ExcelName("Power")]
		public string Power { get; private set; }

		[ExcelName("Second hand")]
		public string SecondHand { get; private set; }


		public static ExcelSheet LoadSheet()
		{
			return Excel.Load(@"TestData\TestData_Cars.xlsx").LoadSheet();
		}

		public static TestData_Cars LoadTestData(int row)
		{
			var testData = LoadSheet();
			var testDataRow = testData.GetRow<TestData_Cars>(row);
			testDataRow.FormatData();
			return testDataRow;
		}

		public static List<TestData_Cars> LoadAllTestData()
		{
			var res = new List<TestData_Cars>();
			var testData = LoadSheet();
			for(int i = 2; i <= testData.MaxRow; i++)
			{
				res.Add(LoadTestData(i));
			}
			return res;
		}

		public static void ForAll(Action<TestData_Cars> action)
		{
			var testData = LoadAllTestData();
			foreach (var item in testData)
			{
				action(item);
			}
		}

		public static void LoadVariable(ITester t, string key, string value)
		{
			t.Log($"Key: \"{key}\", Value: \"{value}\"");
			t.SetVariable(key, value);
		}

		public static TestData_Cars LoadTestDataIntoVariables(ITester t, int row)
		{
			t.Log($"***** Loading TestData TC004_Rev1.TestData.TestData_Cars Row {row}: *****");
			var testDataRow = LoadTestData(row);
			LoadVariable(t, "TestData_Cars:Make", testDataRow.Make);
			LoadVariable(t, "TestData_Cars:Model", testDataRow.Model);
			LoadVariable(t, "TestData_Cars:Price", testDataRow.Price);
			LoadVariable(t, "TestData_Cars:FirstRegistration", testDataRow.FirstRegistration);
			LoadVariable(t, "TestData_Cars:Mileage", testDataRow.Mileage);
			LoadVariable(t, "TestData_Cars:Gearbox", testDataRow.Gearbox);
			LoadVariable(t, "TestData_Cars:FuelType", testDataRow.FuelType);
			LoadVariable(t, "TestData_Cars:Power", testDataRow.Power);
			LoadVariable(t, "TestData_Cars:SecondHand", testDataRow.SecondHand);
			return testDataRow;
		}

		public static int GetSelectedRow(ITester t)
		{
			string portalSeq = t.GetVariable("trio_runsequencenr");
			if (!string.IsNullOrEmpty(portalSeq))
			{
				//in a Portal execution this variable will be set starting with 0, add 2 to find the first data row in Excel
				t.Log($"***** Loading TestData TC004_Rev1.TestData.TestData_Cars portalSeq: {portalSeq} *****");
				return int.Parse(portalSeq) + 2;
			}
			else
			{
				return SelectedRow;
			}
		}

		public static TestData_Cars LoadTestDataIntoVariables(ITester t)
		=> LoadTestDataIntoVariables(t, GetSelectedRow(t));

		partial void FormatData();
	}
}