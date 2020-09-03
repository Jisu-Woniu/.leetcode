/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int[] Intersection(int[] nums1, int[] nums2)
	{
		HashSet<int> hs1 = new HashSet<int>(nums1),
			hs2 = new HashSet<int>(nums2);
		hs1.IntersectWith(hs2);
		int res = new int[hs1.Count];
		hs1.CopyTo(res);
		return res;
	}
}
// @lc code=end