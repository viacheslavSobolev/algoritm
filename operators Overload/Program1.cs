using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_Overload
{
    public class Counter
    {
        public int Value { get; set; }
        public enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

        ~Counter(){ }
        
        public static Counter operator +(Counter c1, Counter c2)
        {
           
            return new Counter { Value = c1.Value + c2.Value };
            
        }
        public static Counter operator -(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value - c2.Value };
        }

        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
        
        public static Counter operator +(Counter c1, int v) // 2-й раз перегруженный оператор "+"
        {
            c1.Value += v;
            return c1;
        }
        public static Counter operator ++(Counter c1)
        {
            return new Counter { Value = c1.Value + 10 };
        }
        public static bool operator true(Counter c1)
        {
            return c1.Value != 0;
        }
        public static bool operator false(Counter c1)
        {
            return c1.Value == 0;
        }
        public static Days ToDay(Days d)
        {
            if (d == Days.Fri)
            { return d; }
            else { return new Days(); }
        }
    }

    

    class Program1
    {
        
        static void Main(string[] args)
        {
            
            Counter counter = new Counter {Value = 12 };
            Counter counter2 = new Counter {Value = 13 };
            bool b = counter < counter2;
            Console.WriteLine(b);
            
            Console.WriteLine($"{counter.Value}");
            ++counter.Value;
            Console.WriteLine($"{counter.Value}");
            Console.ReadKey();

            // Func<int, int, bool> f = (x, y) => x == 2 & y == 1 ? true : false;
            // bool t = f(2, 1);
        }
    }
}
