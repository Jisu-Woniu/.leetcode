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
		if (hs1.Count > hs2.Count)
		{
			var t = hs1;
			hs1 = hs2;
			hs2 = t;
		}
		List<int> hst = new List<int>();
		foreach (int i in hs1)
			if (hs2.Contains(i))
				hst.Add(i);
		int[] res = new int[hst.Count];
		hst.CopyTo(res);
		return res;
	}
}
// @lc code=end