namespace OOP_Day_3_opg2
{
    public class Truck : Vehicle
    {
        public override bool InspectionStatus()
        {
            return (DateTime.Now.Year - ProductionDate.Year > 1) &&
                   (DateTime.Now.Year - LastInspection.Year > 1);
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
        }
    }
}
