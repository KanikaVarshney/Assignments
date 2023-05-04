using Assign5CommonFunctions;

namespace Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            Console.WriteLine(numericFunctions.Add(1, 2, 3, 4, 5, 6));
            //numericFunctions.Add(1, 2, 3, 4, 5, 6);
            string AllEvens = numericFunctions.AllEven(4, 30);
            Console.WriteLine(AllEvens);
            Console.WriteLine(numericFunctions.PrintTable(9));
        }
    }
}