using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float lenght = nums.Length;
            float x = 0;
            for (int i = 0;i < nums.Length; i++)
            {
                x = x + nums[i];
            }
            float average = x / lenght;
            return average;

        }
    }
}
