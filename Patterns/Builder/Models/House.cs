namespace Patterns.Builder.Models
{
    public class House
    {
        public int FloorsNum { get; set; }

        public int WindowsNumber { get; set; }

        public int DoorsNumber { get; set; }

        public bool HasGarden { get; set; }

        public bool HasGarage { get; set; }

        public override string ToString()
        {
            return $"House with {FloorsNum} floors, {DoorsNumber} doors and {WindowsNumber} windows. "
                + (HasGarden ? "Has a gardern. " : string.Empty)
                + (HasGarage ? "Has garage. " : string.Empty);
        }
    }
}