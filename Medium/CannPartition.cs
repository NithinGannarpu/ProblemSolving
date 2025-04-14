using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodeee.Medium
{
    /*Given an integer array nums, return true if you can partition the array into two subsets such that the sum of the elements in both subsets is equal or false otherwise.

 

Example 1:

Input: nums = [1,5,11,5]
Output: true
Explanation: The array can be partitioned as [1, 5, 5] and [11].
Example 2:

Input: nums = [1,2,3,5]
Output: false
Explanation: The array cannot be partitioned into equal sum subsets.*/
    public class CannPartition
    {
        public bool CanPartition(int[] arr)
        {
            int sum = arr.Aggregate((x,y)=>x+y);
            if(sum%2!=0) return false;
            
            return true;
        }
    }
}
