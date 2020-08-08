/*
 * @lc app=leetcode.cn id=122 lang=c
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start


int maxProfit(int* prices, int pricesSize)
{
	int i = 0, profit = 0;
	while (i < pricesSize - 1)
	{
		while (i < pricesSize - 1 && prices[i] >= prices[i + 1])
			i++;
		if (i == pricesSize - 1) return profit;
		int buy = prices[i];
		while (i < pricesSize - 1 && prices[i] < prices[i + 1])
			i++;
		int sell = prices[i];
		profit += sell - buy;
	}
	return profit;
}


// @lc code=end

