using System;
using System.Collections.Generic;

namespace Garage.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero bike = new Zero()
            {
                MainColor = "Yellow",
                CurrentChargePercentage = 100
            };

            Tesla car = new Tesla()
            {
                MainColor = "Orange",
                CurrentChargePercentage = 100
            };

            Cessna plane = new Cessna()
            {
                MainColor = "White",
                CurrentTankPercentage = 70
            };

            Ram truck = new Ram()
            {
                MainColor = "Black",
                CurrentTankPercentage = 80
            };

            Coachmen rv = new Coachmen()
            {
                MainColor = "Brown and White",
                CurrentTankPercentage = 60
            };

            Yamaha jetski = new Yamaha()
            {
                MainColor = "Purple",
                CurrentTankPercentage = 100
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                bike,
                car
            };

            Console.WriteLine("Electric Vehicles");
            electricVehicles.ForEach(electricvehicle =>
            {
                Console.WriteLine($"{electricvehicle.CurrentChargePercentage}");
                // This should charge the vehicle to 100%
                electricvehicle.ChargeBattery();
                Console.WriteLine($"{electricvehicle.CurrentChargePercentage}");
                Console.WriteLine();
            });

            /***********************************************/
            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                truck,
                plane,
                rv,
                jetski
            };

            Console.WriteLine("Gas Vehicles");
            gasVehicles.ForEach(gasvehicle =>
             {
                 Console.WriteLine($"{gasvehicle.CurrentTankPercentage}");
                 // This should completely refuel the gas tank
                 gasvehicle.RefuelTank();
                 Console.WriteLine($"{gasvehicle.CurrentTankPercentage}");
                 Console.WriteLine();
             });
        }
    }
}
