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
        public Narwhal(string name, int age, float weight) : base(name, age, "eeeeeeeeeeeeeee", weight)
        {

        }

        public override void printInfo()
        {
            base.printInfo();
        }
    }
}
