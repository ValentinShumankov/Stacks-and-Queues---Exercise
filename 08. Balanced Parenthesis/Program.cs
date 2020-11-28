using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main( )
        {
            string input = Console.ReadLine();
            Stack<char> parenthesStack = new Stack<char>();
            foreach ( var symbol in input )
            {
                if ( parenthesStack.Any( ) )
                {
                    char check = parenthesStack.Peek();
                    if ( check == '{' && symbol == '}' )
                    {
                        parenthesStack.Pop( );
                        continue;
                    }
                    else if ( check == '[' && symbol == ']' )
                    {
                        parenthesStack.Pop( );
                        continue;
                    }
                    else if ( check == '(' && symbol == ')' )
                    {
                        parenthesStack.Pop( );
                        continue;
                    }
                }
                parenthesStack.Push( symbol );
            }
            Console.WriteLine( !parenthesStack.Any( ) ? "YES" : "NO" );
        }
    }
}
/*
 Balanced Parentheses
Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closed parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses: (, {, and [.
{[()]} - This is a balanced parenthesis.
{[(])} - This is not a balanced parenthesis.
Input
Each input consists of a single line, the sequence of parentheses.
Output 
For each test case, print on a new line "YES" if the parentheses are balanced. 
Otherwise, print "NO". Do not print the quotes.
Constraints
1 ≤ lens ≤ 1000, where lens is the length of the sequence.
Each character of the sequence will be one of {, }, (, ), [, ].
Examples

Input
{[()]}

Output
YES
__________
Input
{[(])}

Output
NO

_________
Input
{{[[(())]]}}

Output
YES
 */