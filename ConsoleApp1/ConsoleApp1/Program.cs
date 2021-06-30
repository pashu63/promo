using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());
            int result = Discount(totalPrice);

            Console.WriteLine(result);
            Console.ReadKey();
        }    


        static int Discount(int x)
        {
            if (x >= 10000)
            {
                return Convert.ToInt32(x - (x * 0.2));

            }
            else
            {
                return x;
            }
        }   
       
    }
   
}
