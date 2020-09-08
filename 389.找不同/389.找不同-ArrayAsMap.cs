/*
 * @lc app=leetcode.cn id=389 lang=csharp
 *
 * [389] 找不同
 */

// @lc code=start
public class Solution
{
	public char FindTheDifference(string s, string t)
	{
		int[] timesOf = new int[26];
		foreach (char c in s)
			++timesOf[c - 'a'];
		foreach (char c in t)
		{
			if (timesOf[c - 'a'] == 0)
				return c;
			--timesOf[c - 'a'];
		}
		return '*';
	}
}
// @lc code=end