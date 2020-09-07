/*
 * @lc app=leetcode.cn id=371 lang=cpp
 *
 * [371] 两整数之和
 */

// @lc code=start
class Solution
{
public:
	int getSum(int a, int b)
	{
		while (b)
		{
			unsigned c = (unsigned)(a & b) << 1;
			a ^= b;
			b = c;
		}
		return a;
	}
};
// @lc code=end