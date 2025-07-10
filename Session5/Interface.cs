using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session5
{
    interface IAnimal
    {
        void MakeSound();
    }

    interface IMovable
    {
        void Move();
    }

    class Dog : IAnimal, IMovable
    {
        public void MakeSound() => Console.WriteLine("Dog barks!");
        public void Move() => Console.WriteLine("Dog runs!");
    }

    public class Interface
    {
        public static void Run()
        {
            Console.WriteLine("5. Interfaces:");
            Dog d = new Dog();
            d.MakeSound();
            d.Move();
            Console.WriteLine();
        }
    }
}
