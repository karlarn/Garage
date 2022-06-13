using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public double CurrentChargePercentage {get; set;}= 45.2;

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by. bzzzzzzzzzzz");
        }
    }
}