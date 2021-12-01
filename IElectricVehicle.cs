using System;

namespace Garage.Vehicles
{
    public interface IElectricVehicle
    {
        double CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
}