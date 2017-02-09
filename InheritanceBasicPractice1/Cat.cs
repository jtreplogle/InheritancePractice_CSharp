using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("DOG CONSTRUCTOR");
        }
        public new void Talk()
        {
            Console.WriteLine("Cat talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Cat song");
        }
    }
}
