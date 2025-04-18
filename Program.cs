using System.Net.WebSockets;
using Leetcodeee.Algos;
using Leetcodeee.Easy;
using Leetcodeee.Medium;

SymmetricNums symmetricNums = new SymmetricNums();
GoodTriplets goodTriplets = new GoodTriplets();
MinOperations minOperations = new MinOperations();
int[] arrat = [3,0,1,1,9,7];
int[] arrat2 = [9,7,5,3];
int val = symmetricNums.CountSymmetricIntegers(1200,1230);
int val2 = goodTriplets.CountGoodTriplets(arrat,7,2,3);
int val3 = minOperations.minOperationss(arrat2,4);
// Console.WriteLine(val3);


//algos...

Knapsack knapsack = new Knapsack();
int[] weights = [5,20,10];
int[] values = [50,140,60];
// int ans = knapsack.Knapsack01(weights,values,30);

SubsetSum subsetSum = new SubsetSum(); // single subset solution...
List<int> ans = subsetSum.sumSubset(6,[1,2,3,4]);
//  = subsetSum;
// foreach (int i in ans)
//     Console.WriteLine(i);
//Console.WriteLine(ans);
int[] arra = [1,2,3,4];
List<int> ints = new List<int>();
List<List<int>> allSubsets = new List<List<int>>();
subsetSum.solveSubset(6,arra.Length-1,arra,ints,allSubsets);
// foreach(var subset in allSubsets)
// {
//     Console.WriteLine(string.Join(", ", subset));
// }

int[] nums = { 3, 1, 2, 3 };
        int target = 6;
        List<List<int>> result = new List<List<int>>();
        List<int> curr = new List<int>();
        subsetSum.solveSubsetMemo(target,nums.Length-1,nums,curr,result);

        // Console.WriteLine("Subsets that sum to " + target + ":");
        // foreach (var subset in result)
        // {
        //     Console.WriteLine(string.Join(", ", subset));
        // }

CountPairs countPairs = new CountPairs();
// Console.WriteLine(countPairs.CpPair([1,2,3,4],1));

Number_of_Partitions number_Of_Partitions = new();
Console.WriteLine(number_Of_Partitions.NumberOfPartitions("aaacb"));

