using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW6.ElectricalAppliances.KitchenAppliances;
using HW6.Wires;

namespace HW6.ElectricalApplianceFactories
{
    public class StoveFactory : IElectricalApplianceFactory
    {
        public ElectricalAppliance CreateElectrialAppliance(string name, int energyCost)
        {
            return new Stove(name, energyCost);
        }

        public IWire CreateWire()
        {
            return new StoveWire();
        }
    }
}
