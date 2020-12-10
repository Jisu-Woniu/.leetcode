/*
 * @lc app=leetcode.cn id=557 lang=csharp
 *
 * [557] 反转字符串中的单词 III
 */
using System;
// @lc code=start
public class Solution
{
	public string ReverseWords(string s)
	{
		string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < words.Length; i++)
		{
			char[] chars = words[i].ToCharArray();
			Array.Reverse(chars);
			words[i] = new string(chars);
		}
		return string.Join(' ', words);
	}
}
// @lc code=end