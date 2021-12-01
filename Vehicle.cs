using System;

namespace Garage.Vehicles
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }


        public virtual void Drive()
        {
            Console.WriteLine("Vehicle : Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle quickly turns {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The Vehicle gently rolls to a stop!");
        }
    }
}