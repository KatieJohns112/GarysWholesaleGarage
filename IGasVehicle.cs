using System;

namespace Garage.Vehicles
{
    public interface IGasVehicle
    {
        double CurrentTankPercentage { get; set; }
        void RefuelTank();
    }
}