/*
 * @lc app=leetcode.cn id=1310 lang=csharp
 *
 * [1310] 子数组异或查询
 */

// @lc code=start
public class Solution
{
	public int[] XorQueries(int[] arr, int[][] queries)
	{
		int n = arr.Length, m = queries.Length;
		int[] xors = new int[n + 1];
		for (int i = 0; i < n; i++)
		{
			xors[i + 1] = xors[i] ^ arr[i];
		}
		int[] ans = new int[m];
		for (int i = 0; i < m; i++)
		{
			ans[i] = xors[queries[i][1] + 1] ^ xors[queries[i][0]];
		}
		return ans;
	}
}
// @lc code=end