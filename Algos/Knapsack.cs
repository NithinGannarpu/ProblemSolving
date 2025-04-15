namespace Leetcodeee.Algos
{
    public class Knapsack
    {
        int[][] dp;
        public int Knapsack01(int[] weights , int[] values, int capacity)
        {
            int len = weights.Length;

            dp = new int[len][];
            for (int i = 0; i < len; i++)
            {
                dp[i] = new int[capacity + 1];
                Array.Fill(dp[i], -1);
            }

            // int ans = solveKnapsack01Recur(capacity,len-1,weights,values);
            int ans = solveKnapsack01Recur(capacity,len-1,weights,values);
            return ans;
        }

        int solveKnapsack01Recur(int capacity,int index,int[] weights,int[] values)
        {
            if(index<0 || capacity <0)
                return 0;
            
            if(weights[index]>capacity)
                return solveKnapsack01Recur(capacity,index-1,weights,values);


            int includeNth = values[index] + solveKnapsack01Recur(capacity-weights[index],index-1,weights,values);

            int excludeNth = solveKnapsack01Recur(capacity,index-1,weights,values);

            return Int32.Max(includeNth,excludeNth);
        }// O(2^n) -> time complexity




        int solveKnapsack01Memo(int capacity,int index,int[] weights,int[] values)
        {
            if(index<0 || capacity <0)
                return 0;

            if(dp[index][capacity]!=-1)
                return dp[index][capacity];
            
            if(weights[index]>capacity)
                return solveKnapsack01Memo(capacity,index-1,weights,values);


            int includeNth = values[index] + solveKnapsack01Memo(capacity-weights[index],index-1,weights,values);

            int excludeNth = solveKnapsack01Memo(capacity,index-1,weights,values);

            dp[index][capacity] =  Int32.Max(includeNth,excludeNth);
            return dp[index][capacity];
        }//O(Len*weight)



    }
}