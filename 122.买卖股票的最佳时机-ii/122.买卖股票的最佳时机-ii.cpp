/*
 * @lc app=leetcode.cn id=122 lang=cpp
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start
class Solution
{
public:
	int maxProfit(vector<int> &prices)
	{
		int i = 0, profit = 0;
		while (i < prices.size() - 1)
		{
			while (i < prices.size() - 1 && prices[i] >= prices[i + 1])
				i++;
			if (i == prices.size() - 1)
				return profit;
			int buy = prices[i];
			while (i < prices.size() - 1 && prices[i] < prices[i + 1])
				i++;
			int sell = prices[i];
			profit += sell - buy;
		}
		return profit;
	}
};
// @lc code=end