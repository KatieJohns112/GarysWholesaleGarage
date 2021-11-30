using System;
namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram model2 = new Ram();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            model2.Drive();
        }
    }
}