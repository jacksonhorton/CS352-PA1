/*
 * Classwork 1
 * Program.cs
 * Jackson Horton
 * 1/23/2023
 * 
 * Exploring abstrat classes and inheritance of classes.
 * This file acts as the main function and shows the functionality
 * of the classes.
 * 
 * Has a list of animals to test the classes and their inheritance.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    class World
    {
        // main driver
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Narwhal("Big Dave", 35, 20467));
            animals.Add(new Cat("Tom", 7, 19));
            animals.Add(new Cassowary("Lenny", 3, 4.5f));
            animals.Add(new Cat("Jambo", 4, 12.5f));
            animals.Add(new Cat("Bean Juice", 1, 2));
            animals.Add(new Cat("Fish Stick", 14, 5.7f));

            foreach (Animal animal in animals)
            {
                animal.printInfo();
            }

            animals[1].ageUp();
            animals[1].printInfo();
        }
    }
}
