using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ProductExceptSelfClass
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            if (nums.Length <= 1)
                return res;
            int mul = 1;
            int countZeros = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    countZeros++;
                }
                else
                {
                    mul *= nums[i];
                    
                }
                
                    
            }
            if (countZeros!=nums.Length)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (countZeros > 0)
                    {
                        if (countZeros == 1)
                        {
                            if (nums[i] == 0)
                                res[i] = mul;
                            else
                                res[i] = 0;
                        }
                        else
                        {
                            res[i] = 0;
                        }
                    }
                    else
                    {

                        res[i] = mul / nums[i];
                    }
                }
            }
           

            return res;
        }

        public static int[] ProductExceptSelf2(int[] nums) {
            int N = nums.Length;
            int[] result = new int[N];
            int[] leftside = new int[N];
            int[] rightside = new int[N];

            leftside[0] = 1;
            rightside[N - 1] = 1;

            for (int i = 1; i < N; i++)
            {
                leftside[i] = nums[i - 1] * leftside[i - 1];
            }
            for (int i = N-2; i>=0; i--)
            {
                rightside[i] = nums[i + 1] * rightside[i + 1];
            }
            for (int i = 0; i < N; i++)
            {
                result[i] = leftside[i] * rightside[i];
            }

            return result;
        }
        public static int[] ProductExceptSelf3(int[] nums)
        {
            int N = nums.Length;
            int[] result = new int[N];

            result[0] = 1;

            for (int i = 1; i < N; i++)
            {
                result[i] = nums[i - 1] * result[i - 1];
            }
            int right = 1;
            for (int i = N - 1; i >= 0; i--)
            {
                result[i] = result[i] * right;
                right *= nums[i];
            }
            

            return result;
        }
    }
}
