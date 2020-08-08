/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 */

// @lc code=start
public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{
		int res = 0;
		bool endSearch = false;
		if (strs.Length == 0)
			return "";
		if (strs.Length == 1)
			return strs[0];
		for (int i = 0; i < strs[0].Length; i++)
		{
			char ch = strs[0][i];
			for (int j = 1; j < strs.Length; j++)
			{
				if (strs[j].Length==i||strs[j][i] != ch)
				{
					endSearch = true;
					res = i;
					break;
				}
			}
			if (endSearch)
				break;
			if (i == strs[0].Length - 1)
				return strs[0];
		}
		return strs[0].Substring(0, res);
	}
}
// @lc code=end