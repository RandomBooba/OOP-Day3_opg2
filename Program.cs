using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace OOP_Day_3_opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                ProductionDate = new DateTime(2015, 5, 1),
                LastInspection = new DateTime(2020, 6, 1)
            };
            Vehicle myTruck = new Truck
            {
                Brand = "Volvo",
                Model = "FH",
                ProductionDate = new DateTime(2021, 1, 1),
                LastInspection = new DateTime(2022, 1, 1)
            };

            Console.WriteLine(myCar.DisplayInfo());
            Console.WriteLine($"Needs inspection: {myCar.InspectionStatus()}");
            myCar.SetTireType(true);
            Console.WriteLine($"Max Rim Size: {((IWheels)myCar).MaxRimSize}");
            Console.WriteLine("");
            Console.WriteLine(myTruck.DisplayInfo());
            Console.WriteLine($"Needs inspection: {myTruck.InspectionStatus()}");
            myTruck.SetTireType(false);
            Console.WriteLine($"Max Rim Size: {((IWheels)myTruck).MaxRimSize}");
            Console.WriteLine("");
            Console.WriteLine(myTruck.GetInterfaceInfo());
        }
    }
}
