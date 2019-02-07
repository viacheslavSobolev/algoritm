using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using anagram;

namespace TestAnagram_
{
    [TestClass]
    public class UnitTest1
    {

        [DataTestMethod]
        [DynamicData(nameof(GetData),DynamicDataSourceType.Method)]
        public void TestAnagram_Should_Retun_intArray(string[] s1,string[] s2,int[]expected)
        {
            int[] array = Program.anagram(s1,s2);
            bool result = array.SequenceEqual(expected);
                          
                Assert.AreEqual(true, result,$"Error! In case: {string.Join(" ", s1)}___{string.Join(" ", s2)} \n expected: {string.Join("", expected)} \n result:{string.Join("", array)}"); // what is expected              
                Trace.Write($"successfully in case : {string.Join(" ",s1)}___{string.Join(" ", s2)}");
            
                                              
        }


        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new string[] { "a", "jk", "abb", "mn", "abc" },
                                        new string[] { "bb", "kj", "bbc", "op", "def" },
                                           new int[] { -1, 0, 1, 2, 3 } };
            yield return new object[] { new string[] { "aa", "jq", "cbb", "on", "abc" },
                                        new string[] { "bb", "kj", "bcc", "op", "def" },
                                           new int[] { 2, 1, 1, 1, 3 } };
            yield return new object[] { new string[] { "aac","ejq", "dceggg", "on", "cbc" },
                                        new string[] { "bb", "kje", "gggmnc", "oo", "def" },
                                           new int[] { -1, 1, 2, 1, 3 } };

        }
    }
}
