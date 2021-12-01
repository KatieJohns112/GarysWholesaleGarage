using System;

namespace Garage.Vehicles
{
    public class Cessna : Vehicle, IGasVehicle// Propellor light aircraft
    {
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The{MainColor} Cessna flies through the sky. ZOOOM!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The{MainColor} Cessna comes to an abrupt stop.");
        }
    }
}