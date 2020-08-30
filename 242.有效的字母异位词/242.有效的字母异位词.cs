/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public bool IsAnagram(string s, string t)
	{
		Dictionary<char, int> times = new Dictionary<char, int>();
		foreach (char c in s)
		{
			if (times.ContainsKey(c))
				times[c]++;
			else
				times[c] = 1;
		}
		foreach (char c in t)
		{
			if (!times.ContainsKey(c))
				return false;
			times[c]--;
			if (times[c] == 0)
				times.Remove(c);
		}
		return times.Count == 0;
	}
}
// @lc code=end