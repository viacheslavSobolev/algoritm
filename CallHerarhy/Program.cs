using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallHerarhy
{
   public enum Operation {add = 1,remove,next,back};
    struct Q
    {
        public Operation add;
        public Q(int t,string s,Operation o)
        {
            add = o;
            this.t = t;
            M = s;
            
        }

        readonly  int t;
        readonly string M;
       
    }

    class A
    {

        public A()
        {
            Console.WriteLine("constructor A");
        }

       public int F()
       {
            return 0;
       }
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine("constructor B");
        }
        public new int  F()
        {
            return 1;
        }
    }

    

    class Program
    {
        #region 
        static void miniMaxSum(int[] arr)
        {
            long firstSum = 0;
            long secondSum = 0;

            for (int i = 0;i<=3;i++)
            {
                firstSum += arr[i];
            }

            for (int j = 1;j<=4;j++)
            {
                secondSum += arr[j];
            }

            var q = new long[] { firstSum, secondSum }.OrderBy(i=>i).ToArray();
            Console.WriteLine($"{q[0]} {q[1]}");
        }

        #endregion
        static void Main(string[] args)
        {
             miniMaxSum(new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 });
           A a = new B();
            a.F();
            Console.WriteLine(a.F());
            Console.ReadKey();
        }
    }
}
