using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    public class Animal
    {
        private string name;
        private int age;
        private string noise;
        private float weight;

        public Animal(string name, int age, string noise, float weight)
        {
            this.name = name;
            this.age = age;
            this.noise = noise;
            this.weight = weight;
        }

        public void makeNoise()
        {
            Console.WriteLine("*" + noise.ToUpper() + " " + noise.ToUpper() + "*");
        }
        public virtual void printInfo()
        {
            Console.WriteLine("This is " + name + ". He is " + age + " years old and weighs " + weight + " pounds.");
            makeNoise();
        }
        public void ageUp()
        {
            age++;
        }
    }
}
