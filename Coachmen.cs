using System;

namespace Garage.Vehicles
{
    public class Coachmen : Vehicle, IGasVehicle
    {
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }
}