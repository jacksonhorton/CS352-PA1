﻿/*
 * Cat.cs
 * Jackson Horton
 * 1/19/2023
 * 
 * The Cat class is an extension of the Animal class.
 * Inherits the Animal class and overrides its functions.
 * A cat is an animal, so it inherits the Animal class.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    public class Cat : Animal
    {
        public Cat(string name, int age, float weight) : base(name, age, "meow", weight)
        {

        }

        public override void printInfo()
        {
            base.printInfo();
        }
    }
}