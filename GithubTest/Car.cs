using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest
{
    public class Car
    {
        public string NumberPlate { get; set; }
        public string Brand { get; set; }

        public Car(string numberPlate, string brand)
        {
            NumberPlate = numberPlate;
            Brand = brand;
        }

        public void Drive()
        {
            Console.WriteLine("wroom wroom");
        }

    }
}
