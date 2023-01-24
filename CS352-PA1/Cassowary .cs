/*
 * Cassowary.cs
 * Jackson Horton
 * 1/23/2023
 * 
 * The Cassowary class represents an object which is also an animal.
 * It inherits all the methods and variables from the animal class.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    public class Cassowary : Animal
    {
        public Cassowary(string name, int age, float weight, string noise= "bakawk") : base(name, age, noise, weight)
        {

        }

        // Override functions; most just call base functions

        /*
         * override printInfo()
         * prints Cassowary's info
         */
        public override void printInfo()
        {
            base.printInfo();
        }

        /*
         * override makeNoise()
         * makes the Cassowary's noise
         */
        public override void makeNoise()
        {
            base.makeNoise();
        }

        /*
         * override ageUp()
         * increases the Cassowary's age
         */
        public override void ageUp()
        {
            base.ageUp();
        }
    }
}
