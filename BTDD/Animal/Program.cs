
using System;

namespace Animal // Note: actual namespace depends on the project name.
{
    abstract class Animal
    {
        public void eat()
        {
            Console.WriteLine("eat");
        }
        public void makeSound()
        {
            Console.WriteLine("makeSound");
        }
    }
    class Cat:Animal
    {
        public void run()
        {
            Console.WriteLine("run");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("fly");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat_14 = new Cat();
            cat_14.run();
            cat_14.eat();
        }
    }
}
