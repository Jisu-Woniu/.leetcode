/*
 * @lc app=leetcode.cn id=374 lang=csharp
 *
 * [374] 猜数字大小
 */
using System;
// @lc code=start
/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
	public int GuessNumber(int n)
	{
		int l = 1, r = n;
		while (l < r)
		{
			int mid = l + ((r - l) >> 1), j = guess(mid);
			if (j == 0) return mid;
			else if (j == 1) l = mid + 1;
			else r = mid - 1;
		}
		return l;
	}
}
// @lc code=end