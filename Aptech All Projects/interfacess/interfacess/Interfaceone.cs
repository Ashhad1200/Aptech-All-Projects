using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace interfacess
{
    internal interface Interfaceone
    {
        public void add();


       
    }
    internal interface Interfacetwo
    {
        public void add();
    }
    internal interface Interfacethree
    {
        public void add();
    }
    internal interface Interfacefour
    {
        public void add();
    }
    internal interface Interfacefive
    {
        public void add();
    }
class Info: Interfaceone, Interfacetwo, Interfacethree, Interfacefour, Interfacefive
    {
  

        void Interfaceone.add()
        {
            Console.WriteLine(  "inter face one");
        }

        void Interfacetwo.add()
        {
            Console.WriteLine("inter face two");
        }

        void Interfacethree.add()
        {
            Console.WriteLine("inter face three");
        }

        void Interfacefour.add()
        {
            Console.WriteLine("inter face four");
        }

        void Interfacefive.add()
        {
            Console.WriteLine("inter face  five");
        }
    }
}
