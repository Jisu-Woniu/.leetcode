/*
 * @lc app=leetcode.cn id=476 lang=csharp
 *
 * [476] 数字的补数
 */

// @lc code=start
public class Solution
{
	public int FindComplement(int num)
	{
		int t = num, maxd = 0;
		while (t > 0)
		{
			t >>= 1;
			++maxd;
		}
		return num ^ ((1 << maxd) - 1);
	}
}
// @lc code=end