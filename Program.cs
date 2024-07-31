// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram Ram1500 = new Ram();

            fxs.Drive();
            fxs.Turn("but nothing happens, as it is jammed into your car");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("in a full circle");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("inverted");
            mx410.Stop();

            Ram1500.Drive();
            Ram1500.Turn("left");
            Ram1500.Stop();
        }
    }
}
