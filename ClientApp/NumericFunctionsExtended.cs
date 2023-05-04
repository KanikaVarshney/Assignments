using Assign5CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal static  class NumericFunctionsExtended
    {
        public static string AllEven(this NumericFunctions numericFunctions,
               int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                    stringBuilder.Append(i + "\n");
            }
            return stringBuilder.ToString();
        }
        public static string PrintTable(this NumericFunctions numericFunctions, int num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                stringBuilder.Append(num + " * " + i + " = " + num * i + "\n");
            }
            return stringBuilder.ToString();
        }
        public static string AllOdd(this NumericFunctions numericFunctions, int start, int end)
        {

            StringBuilder stringBuilder=new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i % 2 != 0)
                    stringBuilder.Append(i + "\n");
            }
            return stringBuilder.ToString();
        }
        public static string AllPrime(this NumericFunctions numeric,int start,int end )
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = start; i <end; i++)
            {
              int  Count = 0;
                for (int j = 2; j <= i/ 2; j++)
                {
                    if (i % j == 0)
                    {
                        Count++;
                        break;
                    }
                }
                if (Count == 0 && i != 1)
                {
                    stringBuilder.Append(i + "\n");
                }
            }
            return stringBuilder.ToString();
        }

        public static string PrintTableInRange(this NumericFunctions numericFunctions, int start,int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = start; i <end; i++)
            {
                for(int j = start; j < end; j++)
                {
                    stringBuilder.Append(i + " * " + i + " = "  + i * i + "\n");
                }
            }
            return stringBuilder.ToString();
        }

        public static string ReverseAString(this NumericFunctions numericFunctions, string str)
        {
            string s1 = str.ToString();
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
