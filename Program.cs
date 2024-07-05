using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ // Base class
    class Animal
    {
        // Method to be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Another derived class
    class Cat : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the MakeSound method on each instance
            genericAnimal.MakeSound();  // Output: Some generic sound
            dog.MakeSound();            // Output: Bark
            cat.MakeSound();            // Output: Meow
        }
    }

}
