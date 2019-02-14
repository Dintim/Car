using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    partial class Car
    {
        public Car(ref string number, ref string model, ref int year, ref string color, ref double engineCapacity)
        {
            ++id;
            Number = number;
            Model = model;
            Year = year;
            Color = color;
            EngineCapacity = engineCapacity;
            Console.WriteLine("Создан {0} экземпляр объекта Car", id);
        }

        public bool isCarNumber(ref string number)
        {
            return (this.number == number);
        }
    }
}
