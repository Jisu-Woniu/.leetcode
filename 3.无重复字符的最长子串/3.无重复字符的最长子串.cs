/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */
using System;
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		int n = s.Length;
		if (n < 2) return n;
		HashSet<char> range = new HashSet<char>();
		int right = -1, ans = 0;
		for (int left = 0; left < n; left++)
		{
			if (left != 0) range.Remove(s[left - 1]);
			while (right + 1 < n && !range.Contains(s[right + 1]))
				range.Add(s[++right]);
			ans = Math.Max(ans, right - left + 1);
		}
		return ans;
	}
}
// @lc code=end