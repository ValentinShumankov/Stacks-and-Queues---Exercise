using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string [ ] args)
        {
            StringBuilder text = new StringBuilder();
            Stack<string> versions = new Stack<string>();
            versions.Push( text.ToString( ) );
            int numCommands = int.Parse(Console.ReadLine());
            string[] input = null;
            for ( int i = 0; i < numCommands; i++ )
            {
                input = Console.ReadLine( ).Split( );
                int numCommand = int.Parse(input[0]);
                switch ( numCommand )
                {
                    case 1:
                        text.Append( input [ 1 ] );
                        versions.Push( text.ToString() );
                        break;
                    case 2:
                        int counToDelete = int.Parse(input[1]);
                        text.Remove(text.Length  - counToDelete, counToDelete );
                        versions.Push( text.ToString( ) );
                        break;
                    case 3:
                        var index = int.Parse(input[1]);
                        Console.WriteLine( text[ index - 1 ] );
                        break;
                    case 4:
                        if ( versions.Count > 0 )
                        {
                            versions.Pop( );
                            text.Clear( );
                            text.Append( versions.Peek( ));
                        }
                        break;
                }
            }
        }
    }
}
/*
 Simple Text Editor
You are given an empty text. Your task is to implement 4 commands related to manipulating the text
1 someString - appends someString to the end of the text
2 count - erases the last count elements from the text
3 index - returns the element at position index from the text
4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
Input
The first line contains n, the number of operations.
Each of the following n lines contains the name of the operation followed by the command argument,
if any, separated by space in the following format CommandName Argument.
Output
For each operation of type 3 print a single line with the returned character of that operation.
Constraints
1 ≤ N ≤ 105
The length of the text will not exceed 1000000
All input characters are English letters.
It is guaranteed that the sequence of input operation is possible to perform.
Examples
 Input
8
1 abc
3 3
2 3
1 xy
3 2
4
4 
3 1
Output
c
y
a
 
Explanation
There are 8 operations. Initially, the text is empty.
In the first operation, we append abc to the text.
Then, we print its 3rd character, which is c at this point.
Next, we erase its last 3 characters, abc.
After that, we append xy to the text.
The text becomes xy after these previous two modifications.
Then, we are asked to return the 2nd character of the text, which is y.
After that, we have to undo the last update to the text, so it becomes empty.
The next operation asks us to undo the update before that, so the text becomes abc again.
Finally, we are asked to print its 1st character, which is a at this point.
 */