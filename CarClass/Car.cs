using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    partial class Car
    {
        private static int id=0;
        private static string num = "KZ";

        private string color;
        private string model;
        private double engineCapacity;
        private string number;
        private int year;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public double EngineCapacity
        {
            get
            {
                return engineCapacity;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("объем двигателя не может быть отрицательным");
                else
                    engineCapacity = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = num + value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1900)
                    Console.WriteLine("год выпуска автомобиля должен быть не ранее 1900 года");
                else
                    year = value;
            }
        }

        public void printCarInfo()
        {
            Console.WriteLine("номер машины: {0}\n" +
                "модель: {1}\n" +
                "год выпуска: {2}\n" +
                "цвет: {3}\n" +
                "объем двигателя: {4}", number, model, year, color, engineCapacity);
        }

        public int getCarId()
        {
            return id;
        }

        public string convertCarInfoToString()
        {
            string str = "номер машины:" + number +
                ", модель:" + model +
                ", год выпуска:" + Convert.ToString(year) +
                ", цвет:" + color +
                ", объем двигателя:" + Convert.ToString(engineCapacity);
            return str;
        }
        
        public void changeCarInfo(ref string color, ref string model, ref double engCap, ref int year)
        {
            this.color = color;
            this.model = model;
            this.engineCapacity = engCap;
            this.year = year;
        }

        static Car()
        {
            Console.WriteLine("Создан объект Car");
        }

        public Car():this("")
        {   
        }
        public Car(string number):this(number,"")
        {
        }

        public Car(string number, string model):this(number, model, 1900)
        {
        }

        public Car(string number, string model, int year):this(number, model, year, "")
        {
        }

        public Car(string number, string model, int year, string color):this(number, model, year, color, 0)
        {
        }

        public Car(string number, string model, int year, string color, double engineCapacity)
        {
            ++id;
            Number = number;
            Model = model;
            Year = year;
            Color = color;
            EngineCapacity = engineCapacity;
            Console.WriteLine("Создан {0} экземпляр объекта Car", id);
        }
    }
}
