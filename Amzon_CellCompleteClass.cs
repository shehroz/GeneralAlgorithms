using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class Amzon_CellCompleteClass
    {
        public static int[] cellCompete(int[] states, int days)
        {
            if (days == 0)
                return states;
            int leftValue = 0;
            int rightValue = 0;
            for (int i = 0; i < states.Length; i++)
            {
                if (i == states.Length - 1)
                    rightValue = 0;
                else
                    rightValue = states[i + 1];

                if (leftValue == rightValue)
                {
                    leftValue = states[i];
                    states[i] = 0;
                }
                else
                {
                    leftValue = states[i];
                    states[i] = 1;
                }
            }
            cellCompete(states, days - 1);
            return states;
        }
    }
}
