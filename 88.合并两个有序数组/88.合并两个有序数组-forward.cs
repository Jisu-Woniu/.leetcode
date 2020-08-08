/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution
{
	public void Merge(int[] nums1, int m, int[] nums2, int n)
	{
		int i = 0, j = 0;
		List<int> nums3 = new List<int>(m + n);
		while (i < m && j < n)
		{
			if (nums1[i] <= nums2[j])
				nums3.Add(nums1[i++]);
			else
				nums3.Add(nums2[j++]);
		}
		while (i < m)
			nums3.Add(nums1[i++]);
		while (j < n)
			nums3.Add(nums2[j++]);
		i = 0;
		foreach (int itr in nums3)
			nums1[i++] = itr;
		return;
	}
}
// @lc code=end

