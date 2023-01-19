/*
 * Classwork 1
 * Jackson Horton
 * 1/19/2023
 * 
 * Exploring abstrat classes and inheritance of classes.
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

        static void Main(string[] args)
        {
            Animal boi = new Cassowary("Joe", 11, 10.5f);
            boi.printInfo();
            Console.ReadKey();
            boi.ageUp();
            boi.printInfo();
            Console.ReadKey();
        }
    }
}
