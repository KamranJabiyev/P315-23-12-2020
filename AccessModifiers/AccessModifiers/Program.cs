using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
using Demo.Test;
using Demo1;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access modifiers
            #region Public - class, all class members
            //Car car = new Car("BMW","X5");
            //car.Brand = "Mercedes";
            //car.Info();
            //Console.WriteLine(car.Brand);
            #endregion

            #region Private - all class members
            //Car car = new Car("BMW", "X5",200);
            //car.Brand = "test";

            //car.Speed = 500;
            //Console.WriteLine(car.Speed);
            //car.SetSpeed(500);
            //Console.WriteLine(car.GetSpeed());
            //car.GetSpeed();
            //Console.WriteLine(car._speed);
            #endregion

            #region Protected - all class members
            //Car car = new Car("BMW", "X5", 200);
            #endregion

            #region Public readonly - field
            //Car car = new Car("BMW", "X5", 200);
            //Console.WriteLine(car.Color);
            #endregion

            #region Private readonly - field
            //Car car = new Car("BMW", "X5", 200);
            #endregion
            #endregion

            #region Namespace
            //Car car = new Car();
            //Demo.Car car1 = new Demo.Car();
            //Demo1.Person person = new Demo1.Person();
            //Animal animal = new Animal();
            //Car car = new Car();
            //Transport transport = new Transport();
            #endregion
        }
    }
}
