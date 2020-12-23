using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Car
    {
        //property
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _speed;
        protected int horsePower;
        public readonly string Color;
        private readonly int year;
        public int Test {  get; set; }
        public Car()
        {

        }
        public Car(string brand,string model,int speed)
        {
            Brand = brand;
            Model = model;
            _speed = speed;
            Color = "Red";
            year = 2000;
        }

        //encapsulation
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value <= 400)
                {
                    _speed = value;
                    return;
                }
                Console.WriteLine("Zehmet olmasa 400-den yuxari suret set etmeyin!!!");
            }
        }

        //public int GetSpeed()
        //{
        //    return _speed;
        //}

        //public void SetSpeed(int speed)
        //{
        //    if (speed <= 400)
        //    {
        //        _speed = speed;
        //        return;
        //    }
        //    Console.WriteLine("Zehmet olmasa 400-den yuxari suret set etmeyin!!!");
        //}

        public string Info()
        {
            _speed = 300;
            return $"{Brand} {Model} {_speed} {Color} {year}";
        }

        protected void PMethod()
        {

        }
    }
}
