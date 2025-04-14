using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodeee.Easy
{
    public class SymmetricNums
    {
        /*
        You are given two positive integers low and high.

An integer x consisting of 2 * n digits is symmetric if the sum of the first n digits of x is equal to the sum of the last n digits of x. Numbers with an odd number of digits are never symmetric.

Return the number of symmetric integers in the range [low, high].

 

Example 1:

Input: low = 1, high = 100
Output: 9
Explanation: There are 9 symmetric integers between 1 and 100: 11, 22, 33, 44, 55, 66, 77, 88, and 99.
Example 2:

Input: low = 1200, high = 1230
Output: 4
Explanation: There are 4 symmetric integers between 1200 and 1230: 1203, 1212, 1221, and 1230.
 

Constraints:

1 <= low <= high <= 104
        */

        public int countDigits(int num)
        {
            if(num ==0)
                return 0;
            int count = 0;
            while(num!=0)
            {
                num/=10;
                ++count;
            }
            return count;
        }

        public List<int> intToList(int num)
        {
            List<int> numss = new List<int>();
            while(num!=0)
            {
                int digit = num % 10;
                    num/=10;
                numss.Add(digit);
            }
            return numss;
        }

        // public bool isSymmetric(int num)
        // {
        //     if(countDigits(num)%2==1)
        //         return false;
        //     List<int> numDigits = intToList(num);
        //     int lastdig = 0;
        //     int count = numDigits.Count-1;
        //     int lsum = 0 , rsum = 0;
        //     for(int i=0;i<=count;i++)
        //     {
        //         if(i > count-i)
        //             break;
        //         else
        //         {
        //             lsum+=numDigits[i];
        //             rsum+=numDigits[count-i];
        //         }
                
        //     }
        //     return lsum==rsum;
        // }

        //public bool isSymmetric(int num)
        //{
        //    int coun = countDigits(num);
        //    if(coun%2==1)
        //        return false;

        //    string digits = num.ToString();
        //    int lsum = 0, rsum = 0;

        //    for(int i=0;i<coun-1;i++)
        //    {
        //        if(i > coun-i-1)
        //            break;
        //        lsum += digits[i]-'0';
        //        rsum += digits[coun-i-1] - '0';
        //    }
        //    return lsum==rsum;
        //}

        public bool isSymmetric(int num)
        {
            int digits = countDigits(num);
            if (digits % 2 != 0) return false;

            int half = digits / 2;
            int divisor = (int)Math.Pow(10, half);

            int left = num / divisor;
            int right = num % divisor;

            int lsum = 0;
            while (left > 0 || right > 0)
            {
                lsum += left % 10;
                lsum -= right % 10;
                left /= 10;
                right /= 10;
            }

            return lsum == 0;
        }


        public int CountSymmetricIntegers(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++)
            {
                if (isSymmetric(i))
                    count++;
            }
            return count;
        }


    }

    
}
