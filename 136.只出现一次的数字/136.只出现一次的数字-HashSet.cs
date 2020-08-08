/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int SingleNumber(int[] nums)
	{
		HashSet<int> hs = new HashSet<int>();
		foreach (int num in nums)
			if (hs.Contains(num))
				hs.Remove(num);
			else
				hs.Add(num);
		foreach (int num in hs) return num;
		return 0;
	}
}
// @lc code=end

