using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public abstract class ElectricalAppliance
    {
        public bool IsPowered { get; protected set; } = false;

        public int EnergyCost { get; protected set; }

        public string Name { get; }

        public ElectricalAppliance(string name, int energyCost)
        {
            Name = name;

            EnergyCost = energyCost;
        }

        public abstract void ConnectOutlet(IWire wire);

        public new string ToString()
        {
            string str = Name + " Потребляет энергии - " + EnergyCost;

            if (IsPowered)
            {
                return str + ", прибор подключен к розетке";
            }

            return str + ", прибор не подключен к розетке";

        }
        public int CompareTo(ElectricalAppliance electricalAppliance, ComparisonOption option)
        {
            if(option == ComparisonOption.IsPowered)
            {
                return IsPowered.CompareTo(electricalAppliance.IsPowered);
            }

            if(option == ComparisonOption.Name)
            {
                return Name.CompareTo(electricalAppliance.Name);
            }

            if(option == ComparisonOption.EnergyCost)
            {
                return EnergyCost.CompareTo(electricalAppliance.EnergyCost);
            }
            throw new ArgumentException("ComparisonOption is not implement");
        }
    }
}
