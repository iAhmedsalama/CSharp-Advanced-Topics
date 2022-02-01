using System;

namespace Inheritance_vs_Interface.Better_appraoch
{
    public class LandVehicle
    {
        public int NumberOfPassengers { get; set; }
        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting\n" +
                              "Turn key to on");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }

}
