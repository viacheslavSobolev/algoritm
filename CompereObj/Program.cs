using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompereObj
{
    class Program
    {
        class AB
        { 
            
            public override bool Equals(object obj)
            {
                object thisObj = this as object;

                if (thisObj == obj)
                    return true;

                return false;
            }
            
        }

        

        class A:AB
        {
            public int T = 2;
        }
        class B:AB
        {
            public int T = 2;
        }

        static void Main(string[] args)
        {
            
            A a = new A();
            B b = new B();
            
            Console.WriteLine(a.Equals(b));

            Console.ReadKey();

        }
    }
}
