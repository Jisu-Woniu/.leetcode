/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution
{
	public int RemoveElement(int[] nums, int val)
	{
		if (nums.Length == 0) return 0;
		int l = 0, r = nums.Length - 1;
		while (l <= r)
		{
			while (l < nums.Length && nums[l] != val) ++l;
			while (r >= 0 && nums[r] == val) --r;
			if (l > r)
				return r + 1;
			else
				nums[l] = nums[r--];
		}
		return r + 1;
	}
}
// @lc code=end

