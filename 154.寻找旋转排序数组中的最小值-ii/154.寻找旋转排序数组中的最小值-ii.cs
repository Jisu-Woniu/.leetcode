/*
 * @lc app=leetcode.cn id=154 lang=csharp
 *
 * [154] 寻找旋转排序数组中的最小值 II
 */

// @lc code=start
public class Solution
{
	public int FindMin(int[] nums)
	{
		int l = 0, r = nums.Length - 1, p = nums[r];
		while (l < r)
		{
			int mid = (l + r) >> 1;
			if (nums[mid] < nums[r])
			{
				r = mid;
			}
			else if (nums[mid] > nums[r])
			{
				l = mid + 1;
			}
			else
			{
				r--;
			}
		}
		return nums[l];
	}
}
// @lc code=end