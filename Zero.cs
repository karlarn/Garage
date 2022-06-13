using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public double CurrentChargePercentage {get; set;} = 60;

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past. Zoooooom!");
        }
    }
}