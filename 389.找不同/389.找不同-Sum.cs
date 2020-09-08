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
		int m = 0;
		foreach (char c in s)
			m -= c;
		foreach (char c in t)
			m += c;
		return (char)m;
	}
}
// @lc code=end