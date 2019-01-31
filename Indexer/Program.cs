using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        }

        class People
        {
            Person[] data;
            public People()
            {
                data = new Person[2];
            }
            public Person this[int index]
            {
                get { return data[index]; }
                set { data[index] = value; }
            }
        }

        static void Main(string[] args)
        {
            People people = new People();

            people[0] = new Person { Name = "Bob" };
            
            Console.ReadLine();              
        }
    }
}
