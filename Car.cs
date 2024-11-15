namespace OOP_Day_3_opg2
{
    public class Car : Vehicle
    {
        public override bool InspectionStatus()
        {
            return (DateTime.Now.Year - ProductionDate.Year > 4) &&
                   (DateTime.Now.Year - LastInspection.Year > 2);
        }

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 16 : 22;
        }
    }
}
