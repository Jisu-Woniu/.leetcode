/*
 * @lc app=leetcode.cn id=171 lang=csharp
 *
 * [171] Excel表列序号
 */

// @lc code=start
public class Solution
{
	public int TitleToNumber(string s)
	{
		int num = 0;
		foreach (char c in s)
			num = num * 26 + (c - 'A' + 1);
		return num;
	}
}
// @lc code=end