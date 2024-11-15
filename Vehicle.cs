using System;

namespace OOP_Day_3_opg2
{
    public abstract class Vehicle : IWheels
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }

        public int MaxRimSize { get; set; }

        public abstract bool InspectionStatus();
        public virtual string DisplayInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Production Date: {ProductionDate.ToShortDateString()}";
        }

        public string GetInterfaceInfo()
        {
            return ((IWheels)this).Info();
        }

        public abstract void SetTireType(bool isWinterTire);
    }
}
