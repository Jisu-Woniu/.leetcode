/*
 * @lc app=leetcode.cn id=771 lang=csharp
 *
 * [771] 宝石与石头
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int NumJewelsInStones(string J, string S)
	{
		HashSet<char> j = new HashSet<char>(J);
		int num = 0;
		foreach (char c in S)
			if (j.Contains(c))
				++num;
		return num;
	}
}
// @lc code=end