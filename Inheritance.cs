//implement inheritance in c# with example
using System;

namespace OOPPractice
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    //  class ProgramApp
    // {
    //     static void Main(string[] args)
    //     {
    //         // Create an instance of the Dog class
    //         Dog dog = new Dog();

    //         // Call methods from both the base and derived classes
    //         dog.Eat();  // Inherited method from Animal class
    //         dog.Bark(); // Method from Dog class
    //     }
    // }
}