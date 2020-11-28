using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ToAdd = inputs[0];
            int ToRemove = inputs[1];
            int ToLookFor = inputs[2];
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>();
            for ( int i = 0; i < ToAdd; i++ )
            {
                nums.Enqueue( inputNums [ i ] );
            }
            for ( int i = 0; i < ToRemove; i++ )
            {
                if ( nums.Count > 0 )
                {
                    nums.Dequeue( );
                }
            }
            if ( nums.Contains(ToLookFor) )
            {
                Console.WriteLine("true");
            }
            else if(nums.Count > 0)
            {
                Console.WriteLine( nums.ToArray( ).Min( ) ); ;
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
/*
 Basic Queue Operations
Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), an integer S representing the number of elements to dequeue (remove) from the queue and finally an integer X, an element that you should look for in the queue. If it is, print true on the console. If it’s not print the smallest element currently present in the queue. If there are no elements in the sequence, print 0 on the console.
Examples
Input
5 2 32
1 13 45 32 4
Comments
We have to enqueue 5 elements. Then we dequeue 2 of them. Finally, we have to check whether 32 is present in the queue. Since it is we print true.
Output
true 
______________
Input
4 1 666
666 69 13 420
OutPut
13
______________
Input
3 3 90
90 0 90
OutPut
0
 */
