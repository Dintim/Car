using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("введите номер машины");
                string number = Console.ReadLine();
                Console.WriteLine("введите модель машины");
                string model = Console.ReadLine();
                Console.WriteLine("введите год выпуска машины");
                int year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("введите цвет машины");
                string color = Console.ReadLine();
                Console.WriteLine("введите объем двигателя машины");
                double engineCapacity = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
                Car c = new Car(ref number, ref model, ref year, ref color, ref engineCapacity);
                cars.Add(c);
            }
        }
    }
}
