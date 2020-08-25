/*
 * @lc app=leetcode.cn id=217 lang=csharp
 *
 * [217] 存在重复元素
 */

// @lc code=start
public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		HashSet<int> visited = new HashSet<int>();
		foreach (int v in nums)
		{
			if (visited.Contains(v))
				return true;
			visited.Add(v);
		}
		return false;
	}
}
// @lc code=end