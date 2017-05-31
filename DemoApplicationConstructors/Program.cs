using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplicationConstructors
{
    class Program
    {
        //A special method of the class that will be automatically invoked 
        //when an instance of the class is created is called a constructor. 

        //use of constructors is to initialize private fields of the class while creating an instance for the class.

        int a, b;
        public Program()
        {
            a = 100;
            b = 75;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.a);
            Console.WriteLine(p.b);
            Console.ReadLine();
        }
    }
}
