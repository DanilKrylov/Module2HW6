using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW6.Wires;

namespace HW6.ElectricalAppliances.KitchenAppliances
{
    class Stove : KitchenAppliance
    {
        public Stove(string name, int energyCost) : base(name, energyCost)
        {

        }

        public override void ConnectOutlet(IWire wire)
        {
            if (wire is StoveWire) 
            {
                IsPowered = true;
                return; 
            }

            Console.WriteLine("Провод не подошел(");
        }
    }
}
