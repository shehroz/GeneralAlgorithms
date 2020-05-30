using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MinStack
    {

        /** initialize your data structure here. */
        static readonly int Max = 10000;
        int[] stack=new int[Max];
        int top;


        public MinStack()
        {
            top = -1;
        }

        public void Push(int x)
        {
            if (top < Max)
                stack[++top] = x;
        }

        public void Pop()
        {
            if (top >= 0)
            {
                stack[top] = 0;
                top--;
            }
        }

        public int Top()
        {
            if (top >= 0)
                return stack[top];
            return -1;
        }

        public int GetMin()
        {
            
            if (top >= 0)
            {
                int Min = stack[0];
                for (int i = 1; i <= top; i++)
                {
                    Min = Math.Min(Min, stack[i]);
                }
                return Min;
            }
            return -1;
        }
    }

}
