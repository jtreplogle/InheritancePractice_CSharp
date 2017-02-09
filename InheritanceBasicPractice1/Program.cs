using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //New ANIMALS
            Animal a1 = new Animal();
            Console.WriteLine("a1");
            a1.Talk();
            a1.Sing();
            a1.Greet();
        

            Animal a2 = new Dog();
            Console.WriteLine("a2");
            a2.Talk();
            a2.Sing();
            a2.Greet();
            

            Animal a3 = new Cat();
            Console.WriteLine("a3");
            a3.Talk();
            a3.Sing();
            a3.Greet();

            Animal a4 = new Rabbit();
            Console.WriteLine("a4");
            a4.Talk();
            a4.Sing();
            a4.Greet();

            //New Cat
            Cat cc1 = new Cat();
            cc1.Talk();
            cc1.Sing();
            cc1.Greet();

            Cat cc2 = new Cat();
            cc2.Talk();
            cc2.Sing();
            cc2.Greet();

            //New DOG
            Dog d1 = new Dog();
            d1.Talk();
            d1.Sing();
            d1.Greet();

            Dog d2 = new Dog();
            d2.Talk();
            d2.Sing();
            d2.Greet();

            //Color Class 
            Color c1 = new Color();
            c1.Fill();
            c1.Fill("red");

            Color c2 = new Color();
            c2.Fill();
            c2.Fill("yellow");

            Color c3 = new Color();
            c3.Fill();
            c3.Fill("black");

            Green g1 = new Green();
            g1.Fill();
            g1.Fill("violet");

            Orange o1 = new Orange();
            o1.Fill();
            o1.Fill("brown");

            MicrosoftSoftware m1 = new MicrosoftSoftware();

            Console.ReadKey();
        }
    }
}
