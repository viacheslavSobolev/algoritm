using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{

   public class Program
    {

        public static bool EqualChar(string s1,string s2,char c) //whether the second line contains the same number of duplicate characters
        {
            int firsCharSumm = 0;
            int secondCharSumm = 0;

            foreach (var i in s1)
            {
                if (i == c)
                {
                    firsCharSumm++;
                }
            }
            foreach (var i in s2)
            {
                if (i == c)
                {
                    secondCharSumm++;
                }
            }
            if (firsCharSumm == secondCharSumm)
            {
                return true;
            }

            return false;
        } 

        public static int[] anagram(string[] s1,string[] s2)
        {
            var s1L = s1.ToList();
            var s2L = s2.ToList();
            List<int> result = new List<int>();
            int actions = 0;
            bool Skip = default(bool);
            

            for (int i = 0; i < s1L.Count ;i++)//strings in array
            {
                if (s1L[i].Length == s2L[i].Length)
                {
                    s1L[i] = string.Concat(s1L[i].OrderBy(x => x));
                    s2L[i] = string.Concat(s2L[i].OrderBy(x => x));                 
                    actions = s2L[i].Length;
                    
                    for (int j = 0; j < s1L[i].Length; j++)//chars in first array
                    {
                        if (j != s1L[i].Length - 1 ) //if current char == next char
                        {
                            if (s1L[i][j] == s1L[i][j + 1])
                            {
                                Skip = true;
                                if (EqualChar(s1L[i], s2L[i], s1L[i][j]))
                                {
                                    actions--;
                                }
                            }
                        }
                        if(Skip != true)
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
                        Skip = false;                 
                    }
                   
                    result.Add(actions);
                }
                else { result.Add(-1);}
                
            }

            return result.ToArray();
        }



        public static string[] findShedulres(int work_hours, int day_hours, string pattern)
        {
            List<char> listPattern = new List<char>(pattern);//копия входного паттерна для обработки          
            List<char> tempPattern = new List<char>(pattern);

            List<string> result = new List<string>();

            List<int> intPattern = new List<int>();//коллекция часов без учета паттерна
            int knownAmount = 0;//сумма уже известных часов в неделю

            foreach (var i in listPattern)//создание intPattern
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

            for (var i = intPattern.Count - 1; i >= 0; i--)
            {
                if (sum >= day_hours)
                {
                    intPattern[i] = day_hours;
                    sum -= day_hours;
                }
                else
                {
                    if (sum > 0)
                    {
                        intPattern[i] = sum;
                    }
                    else
                    {
                        intPattern[i] = 0;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////////
            if (intPattern[0] != day_hours)
            {

                for (int i = 0, j = 1; j < intPattern.Count+1; i++, j++)//итератор перестановки
                {

                    
                    while (intPattern[i] != day_hours)
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
                        if (j == intPattern.Count)
                        {
                            break;
                        }
                        intPattern[j]--;
                        intPattern[i]++;                       
                    }

                }

            }
            else //если только один вариант
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

            return result.ToArray();
        }




        static void Main(string[] args)
        {

            foreach (var i in anagram(new string[] { "a", "jk", "dceggg", "mn", "cdc" }, new string[] { "bb", "kj", "gggmnc", "op", "def" }))
                Console.WriteLine(i);

            foreach (var i in findShedulres(40, 8, "???8??"))
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
