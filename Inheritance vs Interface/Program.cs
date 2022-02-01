using System;
using System.Collections.Generic;

namespace Inheritance_vs_Interface.Better_appraoch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRenter = "Truck Renter" });
            rentals.Add(new Sailboat() { CurrentRenter = "Sailboat Renter" });
            rentals.Add(new Car() { CurrentRenter = "Car Renter" });

            foreach (var r in rentals)
            {
                if(r is Truck t)
                {
                    t.RentalId = 103;
                    t.NumberOfPassengers = 2;
                    t.PricePerDay = 500;
                    t.Style = TruckType.LongBed;
                    t.StartEngine();
                    t.StopEngine();
                }

                if (r is Sailboat s)
                {
                    s.RentalId = 105;
                    s.PricePerDay = 200;
                    
                }
                if (r is Car c)
                {
                    c.RentalId = 106;
                    c.NumberOfPassengers = 4;
                    c.PricePerDay = 350;
                    c.StartEngine();
                    c.StopEngine();

                }
            }
            foreach (var r in rentals)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
