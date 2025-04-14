using System.Net.WebSockets;
using Leetcodeee.Algos;
using Leetcodeee.Easy;

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
int ans = knapsack.Knapsack01(weights,values,30);
Console.WriteLine(ans);

