using Progile.ATE.Extensions.Excel;
using Progile.ATE.TestFramework;

using System;

namespace AutoScout24_Model.TestData
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        [ExcelName("First registration")]
        public DateTime FirstRegistration { get; set; }

        public double Mileage { get; set; }

        public string Gearbox { get; set; }

        [ExcelName("Fuel type")]
        public string FuelType { get; set; }

        public double Power { get; set; }

        [ExcelName("Second hand")]
        public bool SecondHand { get; set; }

    }
}
