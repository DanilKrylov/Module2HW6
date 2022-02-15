using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.ElectricalAppliances
{
    public abstract class KitchenAppliance : ElectricalAppliance
    {
        public KitchenAppliance(string name, int energyCost): base(name, energyCost)
        {

        }
    }
}
