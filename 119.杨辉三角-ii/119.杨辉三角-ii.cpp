/*
 * @lc app=leetcode.cn id=119 lang=cpp
 *
 * [119] 杨辉三角 II
 */
#include <vector>
using namespace std;
// @lc code=start
class Solution {
public:
	vector<int> getRow(int rowIndex) {
		vector<int> nextRow;
		nextRow.push_back(1);
		if (rowIndex == 0)
			return nextRow;
		for (int i = 1; i <= rowIndex; i++)
		{
			for (int j = nextRow.size() - 1; j >= 1; --j)
				nextRow[j] += nextRow[j - 1];
			nextRow.push_back(1);
		}
		return nextRow;
	}
};
// @lc code=end

