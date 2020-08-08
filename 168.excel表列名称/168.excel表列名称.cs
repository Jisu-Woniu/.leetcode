/*
 * @lc app=leetcode.cn id=168 lang=csharp
 *
 * [168] Excel表列名称
 */

// @lc code=start
public class Solution
{
	public string ConvertToTitle(int n)
	{
		string s = "";
		while (n != 0)
		{
			s = (char)((n - 1) % 26 + 'A') + s;
			n = (n - 1) / 26;
		}
		return s;
	}
}
// @lc code=end