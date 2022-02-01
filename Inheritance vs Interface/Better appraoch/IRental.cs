using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_vs_Interface.Better_appraoch
{
    internal interface IRental
    {
         int RentalId { get; set; }
         string CurrentRenter { get; set; }
         decimal PricePerDay { get; set; }
    }

}
