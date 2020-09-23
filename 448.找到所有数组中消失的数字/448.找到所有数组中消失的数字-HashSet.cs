/*
 * @lc app=leetcode.cn id=448 lang=csharp
 *
 * [448] 找到所有数组中消失的数字
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public IList<int> FindDisappearedNumbers(int[] nums)
	{
		HashSet<int> appeared = new HashSet<int>(nums);
		List<int> disappeared = new List<int>();
		for (int i = 1; i <= nums.Length; ++i)
			if (!appeared.Contains(i))
				disappeared.Add(i);
		return disappeared;
	}
}
// @lc code=end