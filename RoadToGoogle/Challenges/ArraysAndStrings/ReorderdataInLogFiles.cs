using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class ReorderdataInLogFiles
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            Array.Sort(logs, (log1, log2) =>
             {
                 ///index of the first space
                 int index1 = log1.IndexOf(" ");
                 //getting id portion
                 string id1 = log1.Substring(0, index1);
                 //getting the rest of the string after the space
                 string main1 = log1.Substring(index1 + 1);

                 int index2 = log2.IndexOf(" ");
                 string id2 = log2.Substring(0, index2);
                 string main2 = log2.Substring(index2 + 1);

                 //check if first symbol character or a number
                 bool isDigit1 = char.IsDigit(main1[0]);
                 bool isDigit2 = char.IsDigit(main2[0]);

                 //case if both symbols are characters
                 if(!isDigit1 && !isDigit2)
                 {
                     int value = main1.CompareTo(main2);
                     //additional comparison if both
                     if (value == 0) return id1.CompareTo(id2);
                     return value;
                 }

                 //return isDigit1 ? (isDigit2 ? 0 - if both logs are the digits then just leave them in exact order
                 //isDigit1 ? (isDigit2 ? 0 : 1) - if isDigit2 is letter log it means it comes before digit log and isDigitlog is greater
                 // :-1 if the whole thing evaluates to false then return -1
                 return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
             });

            return logs;
        }
    }
}
