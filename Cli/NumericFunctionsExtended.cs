using Assign5CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cli
{
    internal static class NumericFunctionsExtended
    {
        public static string AllEven(this NumericFunctions numericFunctions,int start,int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    stringBuilder.Append(i + "\n");
                }
                return stringBuilder.ToString();
            }

        }
    }
}
