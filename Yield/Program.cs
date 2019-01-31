using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Yield
{
    class Program
    {
       
        public static int[] birthdayCakeCandles(int[] grades)
        {
            var tempArr = grades.ToList();
            tempArr.RemoveAt(0);
                        
            var sortedList = tempArr.OrderBy(i=>i).ToArray();
            var newList = new List<int>();

            for (int i = 0; i <= sortedList.GetUpperBound(0); i++)
            {
                if (tempArr[i] < 38)
                {
                    newList.Add(tempArr[i]);
                }
                else
                {
                    int tmp, number = tempArr[i];
                    if ((tmp = number % 5) != 0)
                        number += number > -1 ? (5 - tmp) : -tmp;

                    if (number - tmp != 3)
                        newList.Add(number);
                    else if(number - tmp == 3) { newList.Add(sortedList[i]); }
                }
            }

           
            return newList.ToArray<int>();

        }

        public static bool EqualHash(Collection c1, Collection c2)
        {
            if (c1.GetHashCode() == c2.GetHashCode())
                return true;
            else return false;
        }

        public static string[] bigSorting(string[] unsorted)
        {
            var bigList = new List<BigInteger>();
            
            foreach (var i in unsorted)
            {               
                bigList.Add(BigInteger.Parse(i));
            }           
            bigList = bigList.OrderBy(i => i).ToList();


            var strList = new List<string>();
            foreach (var i in bigList)
            {
                strList.Add(i.ToString());
            }
            return strList.ToArray();
        }

        static void Main(string[] args)
        {
            
            string[] arr = new string[] { "8", "1", "2", "100", "12303479849857341718340192371", "3084193741082937", "3084193741082938", "111", "200" };
            foreach (var i in bigSorting(arr))
                Console.WriteLine(i);
            Console.ReadKey();
            
        }
    }
}
