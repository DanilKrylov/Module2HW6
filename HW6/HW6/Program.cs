using System;
using HW6.ElectricalApplianceFactories;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var kettleFactory = new KettleFactory();
            var stoveFactory = new StoveFactory();


            var kettle1 = kettleFactory.CreateElectrialAppliance("KrutoyChaynik", 100);
            kettle1.ConnectOutlet(kettleFactory.CreateWire());

            var kettle2 = kettleFactory.CreateElectrialAppliance("Philips", 120);
            kettle2.ConnectOutlet(kettleFactory.CreateWire());

            var kettle3 = kettleFactory.CreateElectrialAppliance("Kettle3000", 100);

            var stove1 = stoveFactory.CreateElectrialAppliance("SuperStove", 200);

            var stove2 = stoveFactory.CreateElectrialAppliance("Stove++", 220);

            var appliances = new ElectricalAppliance[]
            {
                kettle1,
                kettle2,
                kettle3,
                stove1,
                stove2
            };

            WriteAppliances(appliances);

            Console.WriteLine("Сортируем по употреблению энергии");

            appliances.Sort(ComparisonOption.EnergyCost);

            WriteAppliances(appliances);

            Console.WriteLine("Сортируем по названию");

            appliances.Sort(ComparisonOption.Name);

            WriteAppliances(appliances);

            Console.WriteLine("Сортируем по подключению к сети");

            appliances.Sort(ComparisonOption.IsPowered);

            WriteAppliances(appliances);

            Console.WriteLine("Вы ищите прибор с энергопотреблением 220");

            var item = appliances.SearchAppliance(220);

            Console.WriteLine($"Это {item.ToString()}");

            Console.WriteLine("Общее энергопотребление = " + AllEnergyCost(appliances));

        }
        static void WriteAppliances(ElectricalAppliance[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Приборы:");
            foreach (var elem in arr)
            {
                Console.WriteLine(elem.ToString());
            }
            Console.WriteLine();
        }
        static int AllEnergyCost(ElectricalAppliance[] arr)
        {
            int sum = 0;
            foreach(var item in arr)
            {
                sum += item.EnergyCost;
            }

            return sum;
        }
    }
}
