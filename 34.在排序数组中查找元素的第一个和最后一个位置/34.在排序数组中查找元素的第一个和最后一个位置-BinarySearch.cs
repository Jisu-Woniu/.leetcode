/*
 * @lc app=leetcode.cn id=34 lang=csharp
 *
 * [34] 在排序数组中查找元素的第一个和最后一个位置
 */

// @lc code=start
public class Solution
{
	public int[] SearchRange(int[] nums, int target)
	{
		if (nums == null || nums.Length == 0)
		{
			return new int[2] { -1, -1 };
		}
		if (nums.Length == 1 && nums[0] == target)
		{
			return new int[2] { 0, 0 };
		}

		int l = 0, r = nums.Length - 1;
		while (l < r)
		{
			int mid = (l + r + 1) / 2;
			if (nums[mid] < target)
			{
				l = mid;
			}
			else
			{
				r = mid - 1;
			}
		}
		int first = l == 0 && nums[0] == target ? 0 : l + 1;
		if (first >= nums.Length || nums[first] != target)
		{
			return new int[2] { -1, -1 };
		}

		l = first;
		r = nums.Length - 1;
		while (l < r)
		{
			int mid = (l + r) / 2;
			if (nums[mid] <= target)
			{
				l = mid + 1;
			}
			else
			{
				r = mid;
			}
		}
		int last = l == nums.Length - 1 && nums[l] == target ? l : l - 1;
		return new int[2] { first, last };
	}
}
// @lc code=end