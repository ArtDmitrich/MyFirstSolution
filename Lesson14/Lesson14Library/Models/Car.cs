using Lesson14Library.Attributes;

namespace Lesson14Library.Models
{
    public class Car
    {
        [MyForProperties("[1-2][0,8,9][0-9][0-9]$")]
        public int ManufactureYear { get; set; }
        [MyForProperties(@"^[a-zа-я]{1,16}$")]
        public string Brand { get; set; }
        public string Model { get; set; }
        [MyForProperties("^[A-HJ-NPR-Z\\d]{13}\\d{4}$")]
        public string VIN { get; set; }
        public Car(string brand, string model, int manufactureYear, string vin)
        {
            Brand = brand;
            Model = model;
            ManufactureYear = manufactureYear;
            VIN = vin;
        }
        public override string ToString()
        {
            return $"Car";
        }
    }
}
