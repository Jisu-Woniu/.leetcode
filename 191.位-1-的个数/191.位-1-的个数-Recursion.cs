/*
 * @lc app=leetcode.cn id=191 lang=csharp
 *
 * [191] 位1的个数
 */

// @lc code=start
public class Solution
{
	public int HammingWeight(uint n)
	{
		if (n == 0u) return 0;
		int hw = (int)(n & 1u) + HammingWeight(n >> 1);
		return hw;
	}
}
// @lc code=end