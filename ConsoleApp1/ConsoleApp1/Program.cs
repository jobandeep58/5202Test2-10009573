using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                pery operry = new pery();
                Console.WriteLine(oDog.Cry());

                Cat oCat = new Cat();
                Console.WriteLine(oCat.Cry());

                Console.ReadKey();
        }

//IAnimal.cs
        interface IAnimal
        {
            string Cry();
        }


        //Dog.cs
        class Dog : IAnimal
        {
            public string Cry()
            {
                return "Woof!";
            }
        }


        //Cat.cs
        class Cat : IAnimal
        {
            public string Cry()
            {
                return "Meow!";
            }
        }
    }
    }
}
