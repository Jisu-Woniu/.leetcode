/*
 * @lc app=leetcode.cn id=190 lang=csharp
 *
 * [190] 颠倒二进制位
 */

// @lc code=start
public class Solution
{
	public uint reverseBits(uint n)
	{
		uint res = 0u, rp = 1u, lp = 1u << 31;
		while (lp != 0u)
		{
			res |= ((rp & n) != 0u) ? lp : 0u;
			rp <<= 1; lp >>= 1;
		}
		return res;
	}
}
// @lc code=end