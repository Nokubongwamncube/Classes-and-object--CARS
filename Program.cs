using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_object__CARS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            //creating my first car
            car1.Make = "Mazda";
            car1.Model = "CX5";
            car1.color = "Blue";
            car1.year = 2020;

            Car car2 = new Car();
            //creating my second car
            car2.Make = "Nissan";
            car2.Model = "NP200";
            car2.color = "White";
            car2.year = 2015;

            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.color);
            Console.WriteLine(car1.year);

            Console.WriteLine(car2.Make);
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.color);
            Console.WriteLine(car2.year);

            Console.Read();

        }
    }
}
