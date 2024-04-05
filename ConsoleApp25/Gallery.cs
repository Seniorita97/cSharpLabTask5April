using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Gallery
    {
        public string Name { get; set; }
        public Car[] _cars;

        public Gallery(string name, Car[] cars)
        {
            Name = name;
            _cars = cars;
        }


        public void GetGalleryCarShow()
        {
            foreach (var car in _cars)
            {
                car.GetInfoCar();
            }
        }


        public void GetGallerCarById(int id)
        {
            foreach (var car in _cars)
            {
                if (car.Id == id)
                {
                    car.GetInfoCar();
                }
            }
        
        
        }


        public int SumCarPrice()
        {
            int sum = 0;
            foreach(var car in _cars)
            {
                sum += car.Price;
            }
            return sum;
        }
    }


}
