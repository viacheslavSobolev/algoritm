using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        public static dynamic GetAge(dynamic age)
        {
            
            if (age is int)
            {
                return "int";
            }
            if (age is string)
            {
                return "str";
            }
            return 0; 
        }
        
        static void Main(string[] args)
        {
            dynamic Age = 18;
           
            Console.WriteLine(GetAge(Age));

            Console.ReadKey();
        }
    }
}
