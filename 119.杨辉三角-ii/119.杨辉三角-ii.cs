/*
 * @lc app=leetcode.cn id=119 lang=csharp
 *
 * [119] 杨辉三角 II
 */

// @lc code=start
public class Solution
{
	public IList<int> GetRow(int rowIndex)
	{
		List<int> nextRow = new List<int>() { 1 };
		if (rowIndex == 0) return nextRow;
		for (int i = 1; i <= rowIndex; i++)
		{
			for (int j = nextRow.Count - 1; j >= 1; j--)
				nextRow[j] += nextRow[j - 1];
			nextRow.Add(1);
		}
		return nextRow;
	}
}
// @lc code=end

