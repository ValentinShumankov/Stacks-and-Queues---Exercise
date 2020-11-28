using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.__Truck_Tour
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int countOfPumps = int.Parse(Console.ReadLine());

            var original = new Queue<int>();

            int index = 0;


            for ( int i = 0; i < countOfPumps; i++ )
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                original.Enqueue( input [ 0 ] );
                original.Enqueue( input [ 1 ] );
            }


            while ( true )
            {
                var copy = new Queue<int>(original);

                long litres = copy.Dequeue();
                long distance = copy.Dequeue();

                if ( litres < distance )
                {
                    original.Enqueue( original.Dequeue( ) );
                    original.Enqueue( original.Dequeue( ) );
                }
                else if ( litres >= distance )
                {
                    long leftFuel = litres - distance;

                    while ( copy.Any( ) )
                    {
                        var litresInternal = copy.Dequeue();
                        var distanceInternal = copy.Dequeue();

                        if ( litresInternal + leftFuel >= distanceInternal )
                        {
                            leftFuel = litresInternal + leftFuel - distanceInternal;
                        }
                        else
                        {
                            original.Enqueue( original.Dequeue( ) );
                            original.Enqueue( original.Dequeue( ) );
                            leftFuel = -1;
                            break;
                        }
                    }

                    if ( leftFuel >= 0 )
                    {
                        Console.WriteLine( index );
                        break;
                    }
                }
                index++;
            }
        }
    }
}

/*
 Truck Tour
Suppose there is a circle. There are N petrol pumps on that circle. Petrol pumps are numbered 0 to (N−1) (both inclusive). You have two pieces of information corresponding to each of the petrol pump: (1) the amount of petrol that particular petrol pump will give, and (2) the distance from that petrol pump to the next petrol pump.
Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the petrol pumps. Calculate the first point from where the truck will be able to complete the circle. Consider that the truck will stop at each of the petrol pumps. The truck will move one kilometer for each liter of the petrol.
Input
The first line will contain the value of N
The next N lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump
Output
An integer which will be the smallest index of the petrol pump from which we can start the tour
Constraints
1 ≤ N ≤ 1000001
1 ≤ Amount of petrol, Distance ≤ 1000000000
Input
3
1 5
10 3
3 4
Output 
1
 */