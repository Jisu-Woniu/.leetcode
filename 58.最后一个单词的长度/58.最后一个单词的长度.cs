/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution
{
	public int LengthOfLastWord(string s)
	{
		s = s.Trim();int j = 0;
		for (int i = s.Length - 1; i >= 0; i--)
		{
			if (s[i] != ' ') j++;
			else break;
		}
		return j;
	}
}
// @lc code=end

