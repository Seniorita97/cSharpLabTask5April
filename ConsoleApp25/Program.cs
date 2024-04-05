using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car(180, 50000);
            Car car2 = new Car(100, 30000);
            Car car3 = new Car(150, 45000);


            Car[] _cars = new Car[] { car1, car2, car3 };

            Gallery gallery = new Gallery("BMW", _cars);

            //car1.GetInfoCar();
            //car2.GetInfoCar();
            //car3.GetInfoCar();

            gallery.GetGalleryCarShow();

            gallery.GetGallerCarById(1);
            Console.WriteLine(gallery.SumCarPrice());

        }


    }
    }

