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
		int hw = 0;
		while (n != 0)
		{
			hw += (int)(n & 1u);
			n >>= 1;
		}
		return hw;
	}
}
// @lc code=end