using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
public delegate void calculate(int number1, int number2);
class Calculate
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void divide(int num1, int num2)
        {
            Console.WriteLine(num1 /  num2);
        }
    }
}
