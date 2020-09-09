/*
 * @lc app=leetcode.cn id=392 lang=csharp
 *
 * [392] 判断子序列
 */

// @lc code=start
public class Solution
{
	public bool IsSubsequence(string s, string t)
	{
		if (s.Length == 0) return true;
		int j = 0;
		for (int i = 0; i < t.Length; ++i)
		{
			if (s[j] == t[i]) j++;
			if (j == s.Length) return true;
		}
		return false;
	}
}
// @lc code=end