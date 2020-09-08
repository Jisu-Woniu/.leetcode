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
		char a = '\0';
		foreach (char c in s)
			a ^= c;
		foreach (char c in t)
			a ^= c;
		return a;
	}
}
// @lc code=end