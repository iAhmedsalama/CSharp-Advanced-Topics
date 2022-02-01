using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     * Inheritance is not code-sharing
     * IS-a relationship
     * Need to share common logic
     * sharing just properties or method signature is not enough
     * Inheritance can put you in a conrner
     * you need to ask the question: What is the point?
     * 
     */

//Rental agency in Miami, FL
namespace Inheritance_vs_Interface
{

    public class RentalCar : RentalVehicle
    {
        public CarType Style { get; set; }
        public int Weight { get; set; }
    }
}
