using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ASPQchoice
    {
        int x;
        int y;
       int ch;

 

       public int add(int x, int y)
        {
            return x + y;
        }
       public int sub(int x, int y)
       {
            return x - y;
        }
       public int mul(int x, int y)
        {
            return x * y;
       }
       public int div(int x, int y)
       {
           return x % y;
       }

 

       public void getdata()
       {
           Console.WriteLine("Enter the value of x");
            x = byte.Parse(Console.ReadLine());
           Console.WriteLine("Enter the value of y");
           y = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your choice");
           ch = byte.Parse(Console.ReadLine());
        }
        public void displaydata()
      {
         switch (ch)
          {
               case 1:
                   {
                       Console.WriteLine("Sum of {0} and {1} is {2} ", x, y, add(x , y));
                        break;
                    }
               case 2:
                  {
                      Console.WriteLine("Difference of {0} and {1} is {2}", x, y, sub(x , y));

 


                       break;

 

                    }
              case 3:
                   {
                        Console.WriteLine("Product of {0} and {1} and {2} ", x, y, mul(x , y));

 

                        break;

 

                  }
                case 4:
                  {
                       Console.WriteLine("Quotient of " + x + " and " + y + " is  " + div(x , y));

 

                       break;
                   }
               default:
                   {
                        Console.WriteLine("Invalid choice");
                      break;
}          }

 

 

       }
    }
}
        

