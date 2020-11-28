using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string [ ] args)
        {
            Stack<decimal> num = new Stack<decimal>();
            decimal num1 = 0;
            while ( num1 >= 0 )
            {
                num1+= 10000000000000000000;
                num.Push( num1 );
                Console.WriteLine( num1 );
            }
        }
    }
}
