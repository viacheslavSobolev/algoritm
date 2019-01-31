using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarEvents_2._0
{
    static class ResultRacing
    {
        public static List<Result> Results { get; set; }        
       
        static ResultRacing()
        {
            Results = new List<Result>();                 
        } 

       public static Result GetWiner()
       {           
             Results = Results.OrderBy(i => i.Time).ToList();
             return Results[0];
       }

    }
}
