using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semple
{
   
 
    public class Program
    {
        public static int Dif(int[][] arr)
        {
            int firstSum = 0;
            int secondSum = 0;
            
            for (int i = 0; i<=arr.GetUpperBound(0); i++)
            {
                firstSum += arr[i][i];

            }

            for (int i = 0, j = arr.GetUpperBound(0); i <= arr.GetUpperBound(0) && j >= arr[i].GetLowerBound(0); i++, j--)
            {
                secondSum += arr[i][j];
            }

            return Math.Abs(secondSum - firstSum);
        }

        static void Main(string[] args)
        {

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.Date.ToString("HH:MM:SS"));

            int[][] arr = new int[3][]
            {
                new int []{11,2,4},
                new int []{4,5,6,},
                new int []{10,8,-12}
            };


            Console.WriteLine(Dif(arr));
            
            Console.ReadKey();
        }
    }
}
