/*
 * Narwhal.cs
 * Jackson Horton
 * 1/19/2023
 * 
 * The Narwhal class is an extension of the Animal class.
 * Inherits the Animal class and overrides its functions.
 * The Narwhal is an animal, so it inherits the animal class.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    public class Narwhal : Animal
    {
        public Narwhal(string name, int age, float weight, string noise="eeeeeeeooowww") : base(name, age, noise, weight)
        {

        }

        // Override functions; most just call base functions

        /*
         * override printInfo()
         * prints Narwhal's info
         */
        public override void printInfo()
        {
            Console.WriteLine("*SPLASH*");
            base.printInfo();
        }

        /*
         * override makeNoise()
         * makes the Narwhal's noise
         */
        public override void makeNoise()
        {
            base.makeNoise();
        }

        /*
         * override ageUp()
         * increases the Narwhal's age
         */
        public override void ageUp()
        {
            base.ageUp();
        }
    }
}
