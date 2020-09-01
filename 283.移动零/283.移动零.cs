/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution
{
	public void MoveZeroes(int[] nums)
	{
		int i = 0, j = 0;
		while (i < nums.Length - 1 && j < nums.Length - 1)
		{
			while (i < nums.Length - 1 && nums[i] != 0)
				++i;
			j = i > j ? i : j;
			while (j < nums.Length - 1 && nums[j] == 0)
				++j;
			while (i < nums.Length - 1 && j < nums.Length
				&& nums[i] == 0 && nums[j] != 0)
			{
				nums[i++] = nums[j];
				nums[j++] = 0;
			}
		}
	}
}
// @lc code=end