/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 */
using System;
// @lc code=start
public class Solution
{
	public bool IsPalindrome(string s)
	{
		int i = 0, j = s.Length - 1;
		while (i < j)
		{
			while (i < s.Length && (!char.IsLetterOrDigit(s[i]))) i++;
			while (j >= 0 && (!char.IsLetterOrDigit(s[j]))) j--;
			if (i < j && char.ToLower(s[i++]) != char.ToLower(s[j--])) return false;
		}
		return true;
	}
}
// @lc code=end

