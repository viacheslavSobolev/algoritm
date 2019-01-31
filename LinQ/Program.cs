using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    
    public class Example:IDisposable
    {         
        public void Dispose()
        {
            Console.WriteLine("is disposed");
        }
    }
    
    class Program
    {       
        public static void SomeMethod(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"in {nameof(sender)} event {e.Action}");
        }//event handler of ObservableCollection

        static void Main(string[] args)
        {
            
            string[] cities = { "Moscow", "Berlin", "Tokio", "Budapest" };

            var selectedCities = cities.Where(item => item.ToUpper().StartsWith("B")).OrderBy(item => item); //sample of array elemets

            foreach (var item in selectedCities)
            {
                Console.WriteLine(item);
            }

            

            Console.ReadLine();
        }
    }
}
