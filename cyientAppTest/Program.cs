using System;
using System.Collections.Generic;
using System.Linq;

namespace cyientAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number\n");
            int num = int.Parse(Console.ReadLine());
            NumbersToRoman romanToNumber = new NumbersToRoman();
            string recnum = romanToNumber.IntToRoman(num);
            Console.WriteLine(recnum);

        }
    }

    internal class NumbersToRoman
    {
        public string IntToRoman(int num)
        {
            string romanResult = "";

            if ((num < 0) || (num > 3999))
            {
                romanResult = romanResult + "Invalid Input";
                return romanResult;
            }

            Dictionary<string, int> romanNumbersDictionary = new()
            {
                {
                    "I",
                    1
                },
                {
                    "IV",
                    4
                },
                {
                    "V",
                    5
                },
                {
                    "IX",
                    9
                },
                {
                    "X",
                    10
                },
                {
                    "XL",
                    40
                },
                {
                    "L",
                    50
                },
                {
                    "XC",
                    90
                },
                {
                    "C",
                    100
                },
                {
                    "CD",
                    400
                },
                {
                    "D",
                    500
                },
                {
                    "CM",
                    900
                },
                {
                    "M",
                    1000
                }
            };
           
            foreach (var item in romanNumbersDictionary.Reverse())
            {
                if (num <= 0) break;
                while (num >= item.Value)
                {
                    romanResult += item.Key;
                    num -= item.Value;
                }
            }
            return romanResult;
        }
    }


}

