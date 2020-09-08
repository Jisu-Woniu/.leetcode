/*
 * @lc app=leetcode.cn id=387 lang=csharp
 *
 * [387] 字符串中的第一个唯一字符
 */

// @lc code=start
public class Solution
{
	public int FirstUniqChar(string s)
	{
		int[] timesOf = new int[26];
		foreach (char c in s)
			++timesOf[c - 'a'];
		for (int i = 0; i < s.Length; ++i)
			if (timesOf[s[i] - 'a'] == 1)
				return i;
		return -1;
	}
}
// @lc code=end