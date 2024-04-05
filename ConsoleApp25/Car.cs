using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int StaticCount = 0;
        public int Speed { get; set; }
        public int Price { get; set; }

        public Car(int speed, int price) 
        {
            Speed = speed;
            Price = price;
            Id = ++StaticCount;
        }    


        public void GetInfoCar()
        {
            Console.WriteLine($"Id:{Id} Name:{Name}  Speed:{Speed} Price:{Price}");
        }
    }
}
