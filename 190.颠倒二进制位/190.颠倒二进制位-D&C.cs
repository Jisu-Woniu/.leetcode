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
		n = (n >> 16) | (n << 16);//<=>((n & 0xffff0000) >> 16) | ((n & 0x0000ffff) << 16)
		n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
		n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
		n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);//0xc=0b1100, 0x3=0b0011
		n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);//0xa=0b1010, 0x5=0b0101
		return n;
	}
}
// @lc code=end