using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("DOG CONSTRUCTOR");
        }
        public new void Talk()
        {
            Console.WriteLine("Dog talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog song");
        }

    }
}
