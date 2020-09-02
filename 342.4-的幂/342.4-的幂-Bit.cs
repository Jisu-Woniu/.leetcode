/*
 * @lc app=leetcode.cn id=342 lang=csharp
 *
 * [342] 4的幂
 */

// @lc code=start
public class Solution
{
	public bool IsPowerOfFour(int num) => num > 0 && (num & (num - 1)) == 0 && (num & 0xaaaaaaaa) == 0;
}
// @lc code=end