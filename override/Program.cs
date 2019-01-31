using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    class A
    {
        public virtual void Func()
        {
            Console.WriteLine("func class A");
        }
    }

    class B:A
    {
        public new void  Func()
        {
            Console.WriteLine("func class B");
            
        }
       
    }

    class C:B
    {
        public new void Func()
        {
            Console.WriteLine("func class C");            
        }
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            A b = new C();
            b.Func();          
            Console.ReadKey();
        }
    }
}
