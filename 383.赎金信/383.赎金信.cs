/*
 * @lc app=leetcode.cn id=383 lang=csharp
 *
 * [383] 赎金信
 */

// @lc code=start
public class Solution
{
	public bool CanConstruct(string ransomNote, string magazine)
	{
		int[] dict = new int[26];
		if (magazine.Length < ransomNote.Length)
			return false;
		foreach (char c in magazine)
			dict[c - 'a']++;
		foreach (char c in ransomNote)
		{
			dict[c - 'a']--;
			if (dict[c - 'a'] < 0)
				return false;
		}
		return true;
	}
}
// @lc code=end