/*
 * @lc app=leetcode.cn id=258 lang=csharp
 *
 * [258] 各位相加
 */

// @lc code=start
public class Solution
{
	public int AddDigits(int num) => (num - 1) % 9 + 1;
}
// @lc code=end