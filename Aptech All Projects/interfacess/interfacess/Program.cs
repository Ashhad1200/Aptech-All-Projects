using System;

namespace interfacess
{
    internal class Program
    {
        static void Main(string[] args)
        {
Info inf = new Info();
            Interfaceone intone = inf;
            Interfacetwo inttwo = inf;
            Interfacethree intthree = inf;
            Interfacefour intfour = inf;    
            Interfacefive intfive = inf;
            intone.add();
        }
    }
}
