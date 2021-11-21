using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float Average = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Average += nums[i];
            }
            return Average / nums.Length;
        }
    }
}
