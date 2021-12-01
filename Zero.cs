using System;

namespace Garage.Vehicles
{
    public class Zero : Vehicle, IElectricVehicle// Electric motorcycle
    {
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method body omitted
        }
    }
}