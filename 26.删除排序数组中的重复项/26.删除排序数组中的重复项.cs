/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除排序数组中的重复项
 */

// @lc code=start
public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		if (nums.Length == 0) return 0;
		int newPointer = 0;
		for (int oldPointer = 1; oldPointer < nums.Length; oldPointer++)
		{
			if (nums[oldPointer] != nums[oldPointer - 1])
				nums[++newPointer] = nums[oldPointer];
		}
		return newPointer + 1;
	}
}
// @lc code=end

