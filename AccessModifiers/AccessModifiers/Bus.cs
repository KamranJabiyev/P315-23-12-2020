using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brand,string model,int speed):base(brand,model,speed)
        {

        }

        public void Test()
        {
            PMethod();
            horsePower = 200;
            Brand = "Bmw";
            Console.WriteLine();
        }
    }
}
