using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using anagram;

namespace TestAnagram_
{
    [TestClass]
    public class UnitTest2
    {
        [DataTestMethod]
        [DynamicData(nameof(GetData),DynamicDataSourceType.Method)]
        public void Test_FindShedulres_Should_Retun_StringArray(int week_hours,int day_hours,string pattertn,string[] expected)
        {
            string[] result = Program.findShedulres(week_hours,day_hours,pattertn);
            bool boolResult = result.SequenceEqual(expected);
            
                Assert.AreEqual(true, boolResult,$"Error! In case: {week_hours} {day_hours} {pattertn} \n expected: {string.Join(" ", expected)} \n result:{string.Join(" ", result)}");
                Trace.Write($"successfully in case : {week_hours} {day_hours} {pattertn}");
                                
        }

        public static  IEnumerable<object[]> GetData()
        {
            yield return new object[] { 56, 8, "???8???",new string[] {"8888888"} };
            yield return new object[] { 55, 8, "???8???", new string[] {"7888888",
                                                                        "8788888",
                                                                        "8878888",
                                                                        "8888788",
                                                                        "8888878",
                                                                        "8888887"} };
            yield return new object[] { 40, 8, "???8??",new string[] {  "088888",
                                                                        "178888",
                                                                        "268888",
                                                                        "358888",
                                                                        "448888",
                                                                        "538888",
                                                                        "628888",
                                                                        "718888",
                                                                        "808888",
                                                                        "817888",
                                                                        "826888",
                                                                        "835888",
                                                                        "844888",
                                                                        "853888",
                                                                        "862888",
                                                                        "871888",
                                                                        "880888",
                                                                        "881878",
                                                                        "882868",
                                                                        "883858",
                                                                        "884848",
                                                                        "885838",
                                                                        "886828",
                                                                        "887818",
                                                                        "888808",
                                                                        "888817",
                                                                        "888826",
                                                                        "888835",
                                                                        "888844",
                                                                        "888853",
                                                                        "888862",
                                                                        "888871",
                                                                        "888880" } };
            
        }

    }
}
