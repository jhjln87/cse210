using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int now = 1;
        Console.WriteLine("\n\nEnter a list of numbers, type 0 when finished.");
        while (now != 0) {
            Console.Write("Enter number: ");
            now = int.Parse(Console.ReadLine());
            nums.Add(now);
        }
        float tot = 0, max = 0, sml = 9999;
        for (int i = 0; i < nums.Count; i++) {
            tot += nums[i];
            if (nums[i] > max)
            {
                max = nums[i];
            }
            if (nums[i] < sml && nums[i] > 0) {
                sml = nums[i];
            }

        }
        Console.WriteLine($"The sum is {tot}\nThe average is: {tot/(nums.Count-1)}\nThe largest number is: {max}\nThe smallest positive number is: {sml}\nThe sorted list is:");
        nums.Sort();
        for (int i = 0; i < nums.Count; i++) {
            Console.WriteLine(nums[i]);
        }
    }
}