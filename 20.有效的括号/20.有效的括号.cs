/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
using System.Collections.Generic;

public class Solution
{
	public bool IsValid(string s)
	{
		Stack<char> chk = new Stack<char>();
		foreach (char v in s)
		{
			if (v == '(' || v == '[' || v == '{')
				chk.Push(v);
			else if (chk.Count == 0)
				return false;
			else if (v == ')' && chk.Pop() != '(')
				return false;
			else if (v == ']' && chk.Pop() != '[')
				return false;
			else if (v == '}' && chk.Pop() != '{')
				return false;
		}
		return chk.Count == 0;
	}
}
// @lc code=end