using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplicationConstructors
{
    class ParametrizedConstructor
    {
        public int a, b;
        public ParametrizedConstructor(int i,int j)
        {
            a = i;
            b = j;
        }
    }
    class MainClass
    {
        static void Main()
        {
            ParametrizedConstructor pc = new ParametrizedConstructor(100, 75);
            Console.WriteLine("This is an example of parametrized constructor :");

            Console.WriteLine("\t");
            Console.WriteLine("Value of a=" + pc.a);
            Console.WriteLine("Value of a=" + pc.b);
            Console.Read();
        }
    }

}
