using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ASPQ
    {
        public static void Main()
        {
            int num1;
            int num2;
            int add, sub, product, quotient;
            Console.WriteLine("Enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("Addition of num1 and num2 is" + add);
            sub = num1 - num2;
            Console.WriteLine("Subtraction of num1 and num2 is" + sub);
            product = num1 * num2;
            Console.WriteLine("product of num1 and num2 is" + product);
            quotient = num1 / num2;
            Console.WriteLine("quotient of num1 and num2 is" + quotient);
        }

    }
}
