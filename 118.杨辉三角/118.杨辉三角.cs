/*
 * @lc app=leetcode.cn id=118 lang=csharp
 *
 * [118] 杨辉三角
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public IList<IList<int>> Generate(int numRows)
	{
		IList<IList<int>> pascalTriangle = new List<IList<int>>();
		if (numRows == 0) return pascalTriangle;
		List<int> nextRow = new List<int>() { 1 };
		pascalTriangle.Add(nextRow);
		for (int i = 1; i < numRows; i++)
		{
			nextRow = new List<int>(nextRow);
			for (int j = nextRow.Count - 1; j >= 1; j--)
				nextRow[j] += nextRow[j - 1];
			nextRow.Add(1);
			pascalTriangle.Add(nextRow);
		}
		return pascalTriangle;
	}
}
// @lc code=end