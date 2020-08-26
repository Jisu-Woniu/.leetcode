/*
 * @lc app=leetcode.cn id=231 lang=csharp
 *
 * [231] 2的幂
 */

// @lc code=start
public class Solution
{
	public bool IsPowerOfTwo(int n) => n > 0 && (n & (n - 1)) == 0;
}
// @lc code=end