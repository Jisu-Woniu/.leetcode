/*
 * @lc app=leetcode.cn id=290 lang=csharp
 *
 * [290] 单词规律
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public bool WordPattern(string pattern, string str)
	{
		List<string> words = new List<string>();
		int j = 0;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == ' ')
			{
				words.Add(str.Substring(j, i - j));
				j = i + 1;
			}
			if (i == str.Length - 1)
				words.Add(str.Substring(j, str.Length - j));
		}//Split string into words
		if (pattern.Length != words.Count)
			return false;
		Dictionary<char, string> match = new Dictionary<char, string>();
		HashSet<string> exist = new HashSet<string>();
		for (int i = 0; i < pattern.Length; i++)
		{
			if (match.ContainsKey(pattern[i]))
			{
				if (match[pattern[i]] != words[i])
					return false;
				else continue;
			}
			if (exist.Contains(words[i]))
				return false;
			match.Add(pattern[i], words[i]);
			exist.Add(words[i]);
		}
		return true;
	}
}
// @lc code=end