/*
 * @lc app=leetcode.cn id=344 lang=csharp
 *
 * [344] 反转字符串
 */

// @lc code=start
public class Solution
{
	public void ReverseString(char[] s)
	{
		int l = 0, r = s.Length - 1;
		while (l < r)
		{
			char t = s[l];
			s[l] = s[r];
			s[r] = t;
			l++;
			r--;
		}
	}
}
// @lc code=end