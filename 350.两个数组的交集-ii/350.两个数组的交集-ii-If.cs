/*
 * @lc app=leetcode.cn id=350 lang=csharp
 *
 * [350] 两个数组的交集 II
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int[] Intersect(int[] nums1, int[] nums2)
	{
		if (nums1.Length > nums2.Length)
		{
			int[] t = nums1;
			nums1 = nums2;
			nums2 = t;
		}
		Dictionary<int, int> d1 = new Dictionary<int, int>();
		foreach (int i in nums1)
			if (d1.ContainsKey(i))
				d1[i]++;
			else
				d1[i] = 1;
		List<int> intersection = new List<int>();
		foreach (int j in nums2)
			if (d1.ContainsKey(j))
			{
				intersection.Add(j);
				if (--d1[j] == 0) d1.Remove(j);
			}
		return intersection.ToArray();
	}
}
// @lc code=end