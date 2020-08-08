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
		int i = m - 1, j = n - 1, p = m + n - 1;
		while (i >= 0 && j >= 0)
		{
			if (nums1[i] <= nums2[j])
				nums1[p--] = nums2[j--];
			else
				nums1[p--] = nums1[i--];
		}
		while (j >= 0)
			nums1[p--] = nums2[j--];
		i = 0;
		return;
	}
}
// @lc code=end