namespace Inheritance_vs_Interface.Better_appraoch
{
    public class Sailboat : IRental
    {
        public int RentalId { get ; set ; }
        public string CurrentRenter { get ; set ; }
        public decimal PricePerDay { get ; set ; }
        public override string ToString()
        {
            return  $"RentalId= {RentalId}\n" +
                    $"CurrentRenter= {CurrentRenter}\n" +
                    $"PricePerDay= {PricePerDay}\n" +
                    $"===================================";

        }
    }
}
