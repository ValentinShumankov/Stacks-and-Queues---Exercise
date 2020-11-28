using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int[] inputs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int toPushCount = inputs[0];
            int toPopCount = inputs[1];
            int toLookFor = inputs[2];
            List<int> inputNums = new List<int>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> nums = new Stack<int>();
            for ( int i = 0; i < toPushCount; i++ )
            {
                nums.Push( inputNums [ i ] );
            }
            for ( int i = 0; i < toPopCount; i++ )
            {
                if ( nums.Count > 0 )
                {
                    nums.Pop( );
                }
            }
            if ( nums.Contains( toLookFor ) )
            {
                Console.WriteLine( "true" );
            }
            else
            {
                if ( nums.Count > 0 )
                {
                    Console.WriteLine( nums.ToArray( ).Min( ) );
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
/*
 Basic Stack Operations
Play around with a stack. You will be given an integer N representing the number of elements to push into the stack, an integer S representing the number of elements to pop from the stack and finally an integer X, an element that you should look for in the stack. If it’s found, print "true" on the console. If it isn’t, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.
Input
On the first line you will be given N, S and X, separated by a single space
On the next line you will be given N number of integers
Output
On a single line print either true if X is present in the stack, otherwise print the smallest element in the stack. If the stack is empty, print 0
Examples
Input
5 2 13
1 13 45 32 4
Comments
We have to push 5 elements. Then we pop 2 of them. Finally, we have to check whether 13 is present in the stack. Since it is we print true.
Output
true
__________
Input
4 1 666
420 69 13 666

OutPut
13
 */