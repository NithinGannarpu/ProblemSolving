namespace Leetcodeee.Medium
{
    public class Number_of_Partitions
    {
        /*Given a string s consisting only of characters a, b and c.

Return the number of substrings containing at least one occurrence of all these characters a, b and c.

 

Example 1:

Input: s = "abcabc"
Output: 10
Explanation: The substrings containing at least one occurrence of the characters a, b and c are "abc", "abca", "abcab", "abcabc", "bca", "bcab", "bcabc", "cab", "cabc" and "abc" (again). 
Example 2:

Input: s = "aaacb"
Output: 3
Explanation: The substrings containing at least one occurrence of the characters a, b and c are "aaacb", "aacb" and "acb". 
Example 3:

Input: s = "abc"
Output: 1*/
        public int NumberOfPartitions(string s)
        {
            if(s.Length<3)
                return 0;
            if(s.Length ==3 && s.Contains('a') && s.Contains('b') && s.Contains('c'))
                return 1;
            int count = 0;
            int cLen = 3;
            while(cLen<=s.Length)
            {
                string ss;
                for (int j=0;j<=cLen;j++)
                { if(j + cLen > s.Length) break;
                    ss = s.Substring(j,cLen);
                    if(ss.Contains('a') && ss.Contains('b') && ss.Contains('c')) count++;
                }
                cLen++;
            }
            return count;
        }
    }
}