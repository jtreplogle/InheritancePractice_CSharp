using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Green : Color
    {
        public override void Fill()
        {
            Console.WriteLine("Fill me up with green!");
        }
    }
}
