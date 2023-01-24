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
        public Cassowary(string name, int age, float weight) : base(name, age, "bakawk", weight)
        {

        }
    }
}
