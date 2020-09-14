/*
 * @lc app=leetcode.cn id=434 lang=csharp
 *
 * [434] 字符串中的单词数
 */

// @lc code=start
public class Solution
{
	public int CountSegments(string s)
	{
		int count = 0;
		for (int i = 0; i < s.Length; i++)
			if ((i == 0 || s[i - 1] == ' ') && s[i] != ' ')
				++count;
		return count;
	}
}
// @lc code=end