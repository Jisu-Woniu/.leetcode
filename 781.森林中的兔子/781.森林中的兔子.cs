/*
 * @lc app=leetcode.cn id=781 lang=csharp
 *
 * [781] 森林中的兔子
 */
using System;
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int NumRabbits(int[] answers)
	{
		Dictionary<int, int> multiset = new Dictionary<int, int>();
		foreach (int i in answers)
		{
			if (multiset.ContainsKey(i))
				multiset[i]++;
			else
				multiset.Add(i, 1);
		}
		int ans = 0;
		foreach (int elememt in multiset.Keys)
		{
			int number = multiset[elememt];
			ans += (number + elememt) / (elememt + 1) * (elememt + 1);
		}
		return ans;
	}
}
// @lc code=end

