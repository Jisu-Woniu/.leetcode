/*
 * @lc app=leetcode.cn id=771 lang=csharp
 *
 * [771] 宝石与石头
 */

// @lc code=start
public class Solution
{
	public int NumJewelsInStones(string J, string S)
	{
		long j = 0;
		foreach (char c in J)
			j |= 1L << (c - 'A');
		int num = 0;
		foreach (char c in S)
			if ((j & (1L << (c - 'A'))) != 0)
				num++;
		return num;
	}
}
// @lc code=end