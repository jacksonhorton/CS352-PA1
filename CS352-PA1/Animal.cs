/*
 * Animal.cs
 * Jackson Horton
 * 1/19/2023
 * 
 * The abstract Animal class contains the methods and variables that
 * all animals should have and any subclass will inherit.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    public class Animal
    {
        // private member variables
        private string name;
        private int age;
        private string noise;
        private float weight;

        // Constructor (parameterized)
        public Animal(string name, int age, string noise, float weight)
        {
            this.name = name;
            this.age = age;
            this.noise = noise;
            this.weight = weight;
        }

        /*
         * makeNoise()
         * Prints the noise of the animal to the console.
         */
        public virtual void makeNoise()
        {
            Console.WriteLine("*" + noise.ToUpper() + " " + noise.ToUpper() + "*\n");
        }
        /*
         * printInfo()
         * Prints all the info of the Animal, namely its private member variables.
         */
        public virtual void printInfo()
        {
            Console.WriteLine("This is " + name + ". He is " + age + " years old and weighs " + weight + " pounds.");
            makeNoise();
        }
        /*
         * ageUp()
         * Increments the age of the animal
         */
        public virtual void ageUp()
        {
            Console.WriteLine("Happy birthday, " + name + "!");
            age++;
        }
    }
}
