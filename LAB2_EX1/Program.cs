using System;

namespace LAB2_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculeaza n!
            // n!=1*2*3*...*n

            Console.WriteLine("Introduceti numarul n=");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Nu este corect");


                return;
            }
            double factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

             Console.WriteLine(factorial);
     
            



        }   
    }
}
