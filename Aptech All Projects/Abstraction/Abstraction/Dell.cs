using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Dell : Laptop
    {
        public override void laptopColor()
        {
            Console.WriteLine("Color : Carbon Black");
        }

        public override void laptopSize()
        {
            Console.WriteLine("laptop Size is :  17 Inches");
        }

        public override void processor()
        {
            Console.WriteLine("Processor Brand : Intel\nProcessor Name : Core i5\nProcessor Generation : 11th Gen");
        }

        public override void productName()
        {
            Console.WriteLine("\n\n\n\nModel Name : Inspiron 3511");
        }

        public override void ram()
        {
            Console.WriteLine("RAM : 32 GB\nRAM Type : DDR4");
        }

        public override void rom()
        {
            Console.WriteLine("SSD : Yes\nSSD Capacity : 512 GB");
        }

        public override void screen()
        {
            Console.WriteLine("Graphic Processor : Intel Integrated UHD ");
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
