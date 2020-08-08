/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 */

// @lc code=start
using System.Collections.Generic;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x <= 9) return true;
        List<byte> digits = new List<byte>();
        while (x / 10 != 0)
        {
            digits.Add((byte)(x % 10));
            x /= 10;
        }
        digits.Add((byte)x);
        int n = digits.Count, m = n / 2;
        for (int i = 0; i < m; i++)
        {
            if (digits[i] != digits[n - i - 1])
                return false;
        }
        return true;
    }
}
// @lc code=end