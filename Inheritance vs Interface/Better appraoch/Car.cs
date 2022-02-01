using System;


namespace Inheritance_vs_Interface.Better_appraoch
{
    public class Car : LandVehicle, IRental
    {
        public CarType Style { get; set; }
        public int RentalId 
        { 
            get ; set ; 
        }
        public string CurrentRenter 
        { 
            get ; set ; 
        }
        public decimal PricePerDay 
        { 
            get ; set ; 
        }

        public override string ToString()
        {
            return $"RentalId= {RentalId}\n" +
                    $"CurrentRenter= {CurrentRenter}\n" +
                    $"PricePerDay= {PricePerDay}\n" +
                    $"===================================";

        }
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Car Engine Stoped");
        }
    }
}
