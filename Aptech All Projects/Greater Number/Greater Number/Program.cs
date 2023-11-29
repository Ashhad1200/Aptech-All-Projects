using System;

namespace Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give Us 3 Number");
            Console.WriteLine("Number One");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Two");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Three");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            if (numberOne == numberTwo && numberTwo==numberThree)
            {
                Console.WriteLine("All Are Equal");
            }
           else  if (numberOne > numberTwo && numberOne >numberThree) 
            {
                Console.WriteLine($"Number One Is Greater {numberOne} \n Number One IS : {numberOne} \n Number Two IS : {numberTwo}\n Number One Three :  {numberThree}");
            }
           else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine($"Number Two Is Greater {numberTwo} \n Number One IS : {numberOne} \n Number Two IS : {numberTwo}\n Number One Three :  {numberThree} ");
            }
            else if (numberThree > numberOne && numberThree > numberTwo)
            {
                Console.WriteLine($"Number Three Is Greater {numberThree}\n Number One IS : {numberOne} \n Number Two IS : {numberTwo}\n Number One Three :  {numberThree}");
            }
            
        }
    }
}
0