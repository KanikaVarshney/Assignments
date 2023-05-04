using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class table
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number for which u want to display the table");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for ( int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} X {1}={2}\n",num, i, num * i);
            }
        }

    }
}
