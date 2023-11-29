using System;

namespace KE_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input Your Units To Get The Bills");
            int units = Convert.ToInt32(Console.ReadLine());


            if (units <= 100)
            {
                int result = units * 15;
                Console.WriteLine($"Your Bill Is : {result} According TO Your Units Which Are : {units}");
            }
            else if (units <= 200)
            {
                int result = units * 20;
                Console.WriteLine($"Your Bill Is : {result} According TO Your Units Which Are : {units}");
            }
            else if (units <= 300)
            {
                int result = units * 25;
                Console.WriteLine($"Your Bill Is : {result} According TO Your Units Which Are : {units}");
            }
            else if (units > 301)
            {
                int result = units * 30;
                Console.WriteLine($"Your Bill Is : {result} According TO Your Units Which Are : {units}");
            }




        }
    }
}
