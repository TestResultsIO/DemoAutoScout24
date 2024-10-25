
using System;
using Progile.ATE.Extensions.Excel;

namespace TC004_Rev1.TestData
{
	public partial class TestData_Cars
    {
        // This method is called after loading the data from the Excel but before loading it into the Testcase Variables.
        partial void FormatData()
		{
            //Example for DateTime: format the Excel Value ""31.12.2023 00:00:00" to "31.12.2023
            FirstRegistration = DateTime.Parse(FirstRegistration).Year.ToString();
		}
	}
}
