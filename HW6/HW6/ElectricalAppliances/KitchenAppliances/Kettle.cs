using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW6.Interfaces;
using HW6.Wires;

namespace HW6.ElectricalAppliances.KitchenAppliances
{
    class Kettle : KitchenAppliance, IKettle
    {
        public Kettle(string name, int energyCost) : base(name, energyCost)
        {

        }

        public override void ConnectOutlet(IWire wire)
        {
            if (wire is KettleWire)
            {
                IsPowered = true;
                return;
            }

            Console.WriteLine("Провод не подошел(");
        }

        public void HeatUp()
        {
            if (!IsPowered)
            {
                Console.WriteLine("чайник не подключен");
            }

            Console.WriteLine("Чайник греет воду");
        }
    }
}
