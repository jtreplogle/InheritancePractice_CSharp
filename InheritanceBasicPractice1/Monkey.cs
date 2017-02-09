using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Monkey : Animal
    {
        public Monkey()
        {
            Console.WriteLine("MONKEY CONSTRUCTOR");
        }
        public new void Talk()
        {
            Console.WriteLine("Monkey talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Monkey song");
        }
    }
}
