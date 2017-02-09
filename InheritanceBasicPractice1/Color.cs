using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Color
    {
        public virtual void Fill()
        {
            Console.WriteLine("Fill me up with color");
        }
        public void Fill(string s)
        {
            Console.WriteLine("Fill me up with {0}", s);
        }
    }
}
