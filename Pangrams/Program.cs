using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pangrams
{

    class Program
    {
        static string pangrams(string s, int k)
        {
            List<char> alfavit = new List<char>
            { 'A','B','C','D','E','F',
              'G','H','I','J','K','L',
              'M','N','O','P','Q','R',
              'S','T','U','V','W','X',
              'Y','Z'};

            int countStr = 0;
            s = s.Replace(" ", "");
            s = s.ToUpper();


            for (var i = 0; i <= alfavit.Count - 1; i++)
            {
                for (var j = 0; j <= s.Length - 1; j++)
                {
                    if (alfavit[i] == s[j])
                    {
                        countStr++;
                        break;
                    }
                }
            }
            if (alfavit.Count == countStr)
            {
                return "pangram";
            }
            else if (alfavit.Count > countStr)
            {
                return "not pangram";
            }
            else { return null; }

        }

        static int Fragmentation(List<int> al,int s)
        {           
            int count = 0;

            if (s <= al[(al.Count - 1) / 2])
            {
                for (var i = 0; i <= (al.Count - 1) / 2; i++)
                {
                    if (al[i] == s)
                    {
                        count++;
                    }
                }                
            }
            else
            {
                for (var i = (al.Count - 1) / 2; i <= al.Count - 1; i++)
                {
                    
                        if (al[i] == s)
                        {
                            count++;
                        }
                                      
                }
            }

            return count;
        }
        
          
        static int FindInArray(List<int> l, int k)
        {
            int find = 0;
            int count = 0;
            l.Sort();
            foreach (var i in l)
            {
                find = i - k;
                count += Fragmentation(l, find);
            }

            return count;
            
        }
       

        static int kDifference(List<int> a, int k)
        {
                  
            int countPairs = 0;
            for (var i = 0; i <= a.Count-1; i++)
            {
                for (var j = 0; j <= a.Count-1; j++)
                {
                    
                   if (a[i] - a[j] == k)
                   {
                        countPairs++;
                   }
                    
                }
            }

            return countPairs;
        }


        static int Password(List<int> pas,List<int> kb)
        {

            return 0;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the prize"));
            Console.WriteLine(FindInArray(new List<int> {10,
363374326,
364147530,
61825163,
107306571,
128124602,
139946991,
428047635,
491595254,
879792181,
106926279,
1 },2));
            



            Console.ReadKey();
        }
    }
}
