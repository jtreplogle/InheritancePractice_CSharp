using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Rabbit : Animal
    {
        public Rabbit()
        {
            Console.WriteLine("RABBIT CONSTRUCTOR");
        }
        public new void Talk()
        {
            Console.WriteLine("Rabbit talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Rabbit song");
        }
    }
}
