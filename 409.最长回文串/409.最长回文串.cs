/*
 * @lc app=leetcode.cn id=409 lang=csharp
 *
 * [409] 最长回文串
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int LongestPalindrome(string s)
	{
		Dictionary<char, int> count = new Dictionary<char, int>();
		foreach (char c in s)
			if (count.ContainsKey(c))
				++count[c];
			else
				count[c] = 1;
		int ans = 0;
		foreach (int v in count.Values)
		{
			ans += v / 2 * 2;
			if (v % 2 == 1 && ans % 2 == 0)
				ans++;
		}
		return ans;
	}
}
// @lc code=end