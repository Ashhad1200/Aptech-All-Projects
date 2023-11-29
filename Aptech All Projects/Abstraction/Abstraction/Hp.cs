using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Hp : Laptop
    {
        public override void laptopColor()
        {
            Console.WriteLine("The Color Of The Laptop Is Gold Pink");
        }

        public override void laptopSize()
        {
            Console.WriteLine("laptop Size is :  14 Inches");
        }

        public override void processor()
        {
            Console.WriteLine("With the processor of : Intel Celeron N4120 Processor");
        }

        public override void productName()
        {
            Console.WriteLine( "laptop name is : RG");
        }

        public override void ram()
        {
            Console.WriteLine("This Laptop had the ram of 32 Gb's");
        }

        public override void rom()
        {
            Console.WriteLine("With The Storage Of 1tb SSD");
        }

        public override void screen()
        {
            Console.WriteLine("it has the Intel HD Graphics and had the HD BrightView Screen ");
        }

        public override void systenType()
        {
            Console.WriteLine("system Type 64Bits");
        }

        public override void windows()
        {
            Console.WriteLine("Windows 11");
        }
    }
}
