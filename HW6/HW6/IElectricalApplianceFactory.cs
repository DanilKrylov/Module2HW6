namespace HW6
{
    public interface IElectricalApplianceFactory
    {
        public ElectricalAppliance CreateElectrialAppliance(string name, int energyCost);

        public IWire CreateWire();
    }
}