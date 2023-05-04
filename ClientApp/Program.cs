using Assign5CommonFunctions;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assign5CommonFunctions.NumericFunctions Obj = new Assign5CommonFunctions.NumericFunctions();
            //Console.WriteLine("Main Menu");
            //Console.WriteLine("1. Add ");
            //Console.WriteLine("2. Subtract");
            //Console.WriteLine("3. Divide");
            //Console.WriteLine("4. Maxnum");
            //Console.WriteLine("5. Minnum");
            //Console.WriteLine("6. IsEven");
            //Console.WriteLine("7. IsOdd");
            //Console.WriteLine("8. Multiply");
            //int ch = Byte.Parse(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        Console.WriteLine(Obj.Add(1, 2,3));
            //        break;
            //    case 2:
            //        int? num1 = null;
            //        int num2 = 20;
            //        num1 = Int32.TryParse(Console.ReadLine(), out int i) ? i : null;
            //        Obj.Subtract(num1, num2);
            //        break;
            //    case 3:
            //        Console.WriteLine(Obj.Divide(10, 5));
            //        break;

            //    case 4:
            //        Console.WriteLine(Obj.Maxnum(1, 2, 3, 4, 5, 6));
            //        break;

            //    case 5:
            //        Console.WriteLine(Obj.Minnum(1, 2, 3, 4, 5, 6));
            //        break;

            //    case 6:
            //        Console.WriteLine(Obj.IsEven(6));
            //        break;

            //    case 7:
            //        Console.WriteLine(Obj.IsOdd(6));
            //        break;
            //    case 8:
            //        Console.WriteLine(Obj.Multiply(6,2));
            //        break;

            NumericFunctions numericFunctions = new NumericFunctions();
            //Console.WriteLine(numericFunctions.Add(1, 2, 3, 4, 5, 6));
            //numericFunctions.Add(1, 2, 3, 4, 5, 6);
            string AllEvens = numericFunctions.AllEven(4, 30);
            Console.WriteLine(AllEvens);
            Console.WriteLine(numericFunctions.PrintTable(9));
            string AllOdd = numericFunctions.AllOdd(1, 10);
            Console.WriteLine(AllOdd);
            string AllPrime = numericFunctions.AllPrime(1, 10);
            Console.WriteLine(AllPrime);
            string PrintTableInRange = numericFunctions.PrintTableInRange(2, 10);
            Console.WriteLine(PrintTableInRange);
            string ReverseAString = numericFunctions.ReverseAString("123");
            Console.WriteLine(ReverseAString);



            ClientApp.StringClass stringclass = new ClientApp.StringClass();
            Console.WriteLine(stringclass.ChInASentence());

        }
        }

    }


