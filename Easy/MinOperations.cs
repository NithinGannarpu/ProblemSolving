﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodeee.Easy
{
    /*
      You are given an integer array nums and an integer k.

An integer h is called valid if all values in the array that are strictly greater than h are identical.

For example, if nums = [10, 8, 10, 8], a valid integer is h = 9 because all nums[i] > 9 are equal to 10, but 5 is not a valid integer.

You are allowed to perform the following operation on nums:

Select an integer h that is valid for the current values in nums.
For each index i where nums[i] > h, set nums[i] to h.
Return the minimum number of operations required to make every element in nums equal to k. If it is impossible to make all elements equal to k, return -1.

 

Example 1:

Input: nums = [5,2,5,4,5], k = 2

Output: 2

Explanation:

The operations can be performed in order using valid integers 4 and then 2.

Example 2:

Input: nums = [2,1,2], k = 2

Output: -1

Explanation:

It is impossible to make all the values equal to 2.

Example 3:

Input: nums = [9,7,5,3], k = 1

Output: 4

Explanation:

The operations can be performed using valid integers in the order 7, 5, 3, and 1.
     */
    public class MinOperations
    {
        public int minInArray(int[] arr)
        {
            int min = int.MaxValue;
            foreach(int i in arr)
                min = Int32.Min(min,i);
            return  min;
        }

        public int minOperationss(int[] arr,int k)
        {
            if(minInArray(arr)<k)
                return -1;
            HashSet<int> setts = new HashSet<int>();
            foreach(int i in arr)
                setts.Add(i);
            if(setts.Count == arr.Length) return arr.Length;
            else return arr.Length - setts.Count;
        }

        public int minOP(List<int> arr , int k)
        {
            /*You are given an array nums of positive integers and an integer k.

In one operation, you can remove the last element of the array and add it to your collection.

Return the minimum number of operations needed to collect elements 1, 2, ..., k.

 

Example 1:

Input: nums = [3,1,5,4,2], k = 2
Output: 4
Explanation: After 4 operations, we collect elements 2, 4, 5, and 1, in this order. Our collection contains elements 1 and 2. Hence, the answer is 4.
Example 2:

Input: nums = [3,1,5,4,2], k = 5
Output: 5
Explanation: After 5 operations, we collect elements 2, 4, 5, 1, and 3, in this order. Our collection contains elements 1 through 5. Hence, the answer is 5.
Example 3:

Input: nums = [3,2,5,3,1], k = 3
Output: 4
Explanation: After 4 operations, we collect elements 1, 3, 5, and 2, in this order. Our collection contains elements 1 through 3. Hence, the answer is 4.*/
        int c = 0;
        foreach(int num in arr)
        {
            if(num > k)
                break;
            c++;
        }
        return arr.Count+1-c;
        }
    }
}
