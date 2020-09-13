/*
 * @lc app=leetcode.cn id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public IList<string> FizzBuzz(int n)
	{
		List<string> ls = new List<string>();
		for (int i = 1; i <= n; i++)
		{
			if (i % 15 == 0)
				ls.Add("FizzBuzz");
			else if (i % 3 == 0)
				ls.Add("Fizz");
			else if (i % 5 == 0)
				ls.Add("Buzz");
			else
				ls.Add(i.ToString());
		}
		return ls;
	}
}
// @lc code=end