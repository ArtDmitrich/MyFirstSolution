using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Library.Models
{
    public class CarList
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public void AddCarsWithRandomAge(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var random = new Random();
                Cars.Add(new Car(random.Next(1, 10)));
            }
        }
        public void SetAgeInCarsForeach()
        {
            foreach (var car in Cars)
            {
                car.Age = GetAgeFromYauheniTretsyak();
            }
        }
        public void SetAgeInCarsFor()
        {
            for (int j = 0; j < Cars.Count; j++)
            {
                Cars[j].Age = GetAgeFromYauheniTretsyak();
            }
        }
        public void SetAgeInCarsParallelForeach()
        {
            var result = Parallel.ForEach(Cars, (car) => car.Age = GetAgeFromYauheniTretsyak());
        }
        public void SetAgeInCarsParallelFor()
        {
            Parallel.For(0, Cars.Count, (index) => Cars[index].Age = GetAgeFromYauheniTretsyak());
        }
        private int GetAgeFromYauheniTretsyak()
        {
            return (343 * 34 * DateTime.Now.Millisecond * 77 * (DateTime.Now.Minute + 5)) / DateTime.Now.Minute;
        }
    }
}
