using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public double CurrentTankPercentage {get; set; } = 32;
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flys overhead. WHOOOOOOOSH!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}