using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Factorial !");
            //int factorialNumber =Convert.ToInt32( Console.ReadLine());
            // int factorial = 1;
            // for (int i = 1; i <=factorialNumber; i++)
            // {
            //     factorial =factorial* i;
            // }
            // Console.WriteLine(factorial);

            Console.WriteLine("Even Number Sum");

            Console.WriteLine("Give Us The Limite");
            int lim = Convert.ToInt32(Console.ReadLine());
           int sum = 0;
            for (int i = 2; i <=lim; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
}
