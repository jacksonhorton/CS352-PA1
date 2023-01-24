/*
 * Classwork 1
 * Program.cs
 * Jackson Horton
 * 1/19/2023
 * 
 * Exploring abstrat classes and inheritance of classes.
 * This file acts as the main function and shows the functionality
 * of the classes.
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

            foreach (Animal animal in animals)
            {
                animal.printInfo();
            }
        }
    }
}
