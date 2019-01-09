using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A, int[] B)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Stack<int> fishAlive = new Stack<int>();
        for (int i = 0; i < A.Length; i++)
        {
            var size = A[i];
            var direction = B[i];

            if(fishAlive.Count == 0)
            {
                fishAlive.Push(i);
            }
            else
            {
                while(fishAlive.Count != 0 && direction - B[fishAlive.Peek()] == -1 && A[fishAlive.Peek()] < size)
                {
                    fishAlive.Pop();
                }
                if(fishAlive.Count == 0)
                {
                    fishAlive.Push(i);
                }
                else if( direction - B[fishAlive.Peek()] != -1)
                {
                    fishAlive.Push(i);
                }
            }
        }
        return fishAlive.Count;
    }
}