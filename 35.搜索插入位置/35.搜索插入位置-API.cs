/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution
{
	public int SearchInsert(int[] nums, int target)
	{
		int t = Array.BinarySearch(nums, target);
		return t >= 0 ? t : ~t;
	}
}
// @lc code=end