using System.Runtime.InteropServices;

namespace Leetcodeee.Algos
{
    public class Knapsack
    {
        public int Knapsack01(int[] weights , int[] values, int capacity)
        {
            int len = weights.Length;
            int ans = solveKnapsack01(capacity,len-1,weights,values);
            return ans;
        }

        int solveKnapsack01(int capacity,int index,int[] weights,int[] values)
        {
            if(index<0 || capacity <0)
                return 0;
            
            if(weights[index]>capacity)
                return solveKnapsack01(capacity,index-1,weights,values);


            int includeNth = values[index] + solveKnapsack01(capacity-weights[index],index-1,weights,values);

            int excludeNth = solveKnapsack01(capacity,index-1,weights,values);

            return Int32.Max(includeNth,excludeNth);
        }
    }
}