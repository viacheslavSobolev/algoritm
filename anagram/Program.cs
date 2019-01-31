using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{
    class Program
    {

        public static int[] anagram(string[] s1,string[] s2)
        {
            
            var s1L = s1.ToList();
            var s2L = s2.ToList();
            List<int> result = new List<int>();
            int actions = 0;
            
            for (int i = 0; i < s1L.Count ;i++)//strings in array
            {
                if (s1L[i].Length == s2L[i].Length)
                {
                    s1L[i] = string.Concat(s1L[i].OrderBy(x => x));
                    s2L[i] = string.Concat(s2L[i].OrderBy(x => x));
                    actions = s2L[i].Length;
                    for (int j = 0; j < s1L[i].Length; j++)//chars in first array
                    {
                        if (s1L[i][j] != s1L[i][j]+1 )
                        {
                            for (int k = 0; k < s2L[i].Length; k++)//chars in second array
                            {                               
                                if (s1L[i][j] == s2L[i][k])
                                {                                    
                                    actions--;
                                    break;
                                }
                            }                            
                        }                     
                    }
                    result.Add(actions);
                }
                else{ result.Add(-1);}
                
            }

            return result.ToArray();
        }

       

        public static string[] findShedulres(int work_hours,int day_hours,string pattern)
        {
            List<char> listPattern = new List<char>(pattern);//копия входного паттерна для обработки          
            List<char> tempPattern = new List<char>(pattern);
            
            List<string> result = new List<string>();

            List<int> intPattern = new List<int>();//коллекция часов без учета паттерна
            int knownAmount = 0;//сумма уже известных часов в неделю

            foreach (var i in pattern)//создание intPattern
            {
                if (i == '?')
                {
                    intPattern.Add(0);
                }
                else
                {
                    knownAmount += int.Parse(i.ToString());
                }               
            }
            int sum = work_hours - knownAmount; //сколько осталось для распеределения;

            for (var i = intPattern.Count-1; i >= 0; i--)
            {
                if (sum >= day_hours)
                {
                    intPattern[i] = day_hours;
                    sum -= day_hours;
                }
                else
                {
                    intPattern[i] = sum;
                   
                }

            }


            if (intPattern[0] != day_hours)
            {
                int countPass = 0;//колличество вариантов
                for (int i = 0, j = 1; j <= intPattern.Count; i++, j++)//итератор перестановки
                {
                    for (int k = 0; k < intPattern.Count; k++)//запись в результат
                    {
                        for (int l = 0; l < listPattern.Count; l++)
                        {

                            if (tempPattern[l] == '?')
                            {
                                tempPattern[l] = char.Parse(intPattern[k].ToString());
                                break;
                            }


                        }
                    }
                    result.Add(new string(tempPattern.ToArray()));
                    tempPattern = new List<char>(listPattern);//обнуление временного паттерна для следующего случая
                    countPass++;
                    if (j == intPattern.Count) { break; }
                    while (intPattern[i] != day_hours)
                    {
                        intPattern[j]--;
                        intPattern[i]++;
                    }

                }

            }
            else//если только один вариант
            {
                for (int k = 0; k < intPattern.Count; k++)//запись в результат
                {
                    for (int l = 0; l < listPattern.Count; l++)
                    {

                        if (tempPattern[l] == '?')
                        {
                            tempPattern[l] = char.Parse(intPattern[k].ToString());
                            break;
                        }


                    }
                }
                result.Add(new string(tempPattern.ToArray()));
            }

            return result.ToArray(); ;
        }

        static void Main(string[] args)
        {


            foreach (var i in anagram(new string[] { "a", "jk", "abb", "mn", "abc" }, new string[] { "bb", "kj", "bbc", "op", "def" }))
                Console.WriteLine(i);

            //foreach (var i in findShedulres(23, 8, "???8???"))
            //    Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
