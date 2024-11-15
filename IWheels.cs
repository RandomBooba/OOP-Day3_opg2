namespace OOP_Day_3_opg2
{
    public interface IWheels
    {
        int MaxRimSize { get; set; }
        void SetTireType(bool isWinterTire);

        // Concrete Method
        public string Info()
        {
            return "Brug mig for alle objekter som køres på hjul.";
        }
    }
}
