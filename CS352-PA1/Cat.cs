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
