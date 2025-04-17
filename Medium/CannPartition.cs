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
        List<List<int>> subsets = new List<List<int>>();
        public void subsetSum(int sum,int index,int[] arr,List<int> current)
        {
            if(sum<0||index<0)
                return;
            if(sum==0)
            {
                subsets.Add(new List<int>(current));
                return;
            }

            current.Add(arr[index]);
            subsetSum(sum-arr[index],index-1,arr,current);

            current.RemoveAt(current.Count-1);
            subsetSum(sum,index-1,arr,current);

            return;
        }
        public void solveSubset(int sum,int[] arr)
        {
            List<int> current = new List<int>();
            subsetSum(sum,arr.Length-1,arr,current);
        }

        public bool CanPartition(int[] arr)
        {
            int sum = arr.Aggregate((x,y)=>x+y);
            if(sum%2!=0) return false;
            solveSubset(sum/2,arr);
            if(subsets.Count >=2) return true;
            return false;
        }
    }
}
