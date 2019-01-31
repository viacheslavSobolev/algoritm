using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenguru
{


    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int firstPos = x1;
            int secPos = x2;
            int countIteration = 0;
           
            while (firstPos != secPos)
            {
                firstPos += v1;
                secPos += v2;
                countIteration++;
                if (countIteration > 100000)
                {
                    return "NO";
                    
                }
                if (countIteration <= 100000 && firstPos == secPos)
                {
                    return "YES";
                }
            }
            return null;                         
        }
       
        static void Main(string[] args)
        {
            
            Console.WriteLine(kangaroo(0,3,4,2));
            Console.ReadKey();
        }
    }
}
