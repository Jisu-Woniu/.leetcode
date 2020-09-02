/*
 * @lc app=leetcode.cn id=345 lang=csharp
 *
 * [345] 反转字符串中的元音字母
 */

// @lc code=start
public class Solution
{
	bool IsVowel(char c)
	{
		c = char.ToLower(c);
		return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
	}
	public string ReverseVowels(string s)
	{
		if (s.Length <= 1) return s;
		char[] chars = s.ToCharArray();
		int i = 0, j = chars.Length - 1;
		while (i < s.Length && !IsVowel(chars[i])) i++;
		while (j >= 0 && !IsVowel(chars[j])) j--;
		while (i < j && i < s.Length && j >= 0)
		{
			char t = chars[i]; chars[i] = chars[j]; chars[j] = t;
			i++; j--;
			while (i < s.Length - 1 && !IsVowel(chars[i])) i++;
			while (j > 0 && !IsVowel(chars[j])) j--;
		}
		return new string(chars);
	}
}
// @lc code=end