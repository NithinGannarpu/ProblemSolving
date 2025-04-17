using System.Runtime.InteropServices;

namespace Leetcodeee.Algos
{
    public class SubsetSum
    {
        public List<int> Lsiis = new List<int>();
        public List<int> sumSubset(int sum, int[] arr)
        {
            bool ans = solveSubsetSum(sum, arr.Length - 1, arr);
            return ans ? Lsiis : new List<int>();
        }
        public bool solveSubsetSum(int sum, int index, int[] arr)
        {
            if (sum < 0 || index < 0)
                return false;

            if (sum == 0)
                return true;

            Lsiis.Add(arr[index]);
            bool picked = solveSubsetSum(sum - arr[index], index - 1, arr);
            if (picked == true)
                return true;

            Lsiis.RemoveAt(Lsiis.Count - 1);
            bool notPicked = solveSubsetSum(sum, index - 1, arr);
            if (notPicked == true)
                return true;

            return false;
        }

        // public List<List<int>> allSubsets = new List<List<int>>();
        public void solveSubset(int sum, int index, int[] arr,List<int> current,List<List<int>> allSubsets)
        {
            if(sum==0)
            {
                allSubsets.Add(new List<int>(current)); // quite important to add a new list rather than just adding a reference.....
                return;
            }
            if(sum<0||index<0)
                return;

            current.Add(arr[index]);
            solveSubset(sum-arr[index],index-1,arr,current,allSubsets);

            current.RemoveAt(current.Count-1);
            solveSubset(sum,index-1,arr,current,allSubsets);

            return;
        }//Always use new List<int>(current) when storing paths during recursive backtracking. Otherwise, you’re storing references to a single changing list, not distinct snapshots.
    
        HashSet<(int, int)> memo = new HashSet<(int, int)>();

public void solveSubsetMemo(int sum, int index, int[] nums, List<int> current, List<List<int>> allSubsets)
{ // this one is bs..... do not use it..    
    if (sum < 0 || index < 0)
        return;

    if (sum == 0)
    {
        allSubsets.Add(new List<int>(current));
        return;
    }

    var key = (index, sum);
    if (memo.Contains(key))
        return;

    current.Add(nums[index]);
    solveSubsetMemo(sum - nums[index], index - 1, nums, current, allSubsets);

    current.RemoveAt(current.Count - 1); 
    solveSubsetMemo(sum, index - 1, nums, current, allSubsets);

    memo.Add(key);
}

    }
}
