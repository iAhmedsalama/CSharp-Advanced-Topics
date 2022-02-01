using System;

namespace Inheritance_vs_Interface.Better_appraoch
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public int RentalId { get; set; }
        public string CurrentRenter { get ; set ; }
        public decimal PricePerDay { get ; set ; }

        public override string ToString()
        {
            return  $"Truck Type= {Style}\n" +
                    $"RentalId= {RentalId}\n" +
                    $"CurrentRenter= {CurrentRenter}\n" +
                    $"PricePerDay= {PricePerDay}\n" +
                    $"===================================";
        }

        public override void StartEngine()
        {
            Console.WriteLine("Truck Engine Started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Truck Engine Stoped");
        }
    }

    
}
