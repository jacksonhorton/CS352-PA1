using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_PA1
{
    class Animal
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

        public string Name { get => name; }

        public void makeNoise()
        {
            Console.WriteLine("*" + noise.ToUpper() + " " + noise.ToUpper() + "*");
        }
        public virtual void printInfo()
        {
            Console.WriteLine("This is " + name + ". He is " + age + " years old and weighs " + weight + " pounds.");
            makeNoise();
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age, float weight) : base(name, age, "ruff", weight)
        {

        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine(Name + " is also the goodest boi!");
        }
    }

    class World
    {

        static void Main(string[] args)
        {
            Animal boi = new Dog("Joe", 11, 100.1f);
            boi.printInfo();
            Console.ReadKey();

        }
    }
}
