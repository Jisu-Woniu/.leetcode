/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution
{
	public class interval
	{
		public int lSum, rSum, iSum, maxSum;
		public interval(int lS, int rS, int iS, int mS)
		{
			lSum = lS;
			rSum = rS;
			iSum = iS;
			maxSum = mS;
		}
	}
	public interval merge(interval l, interval r)
	{
		int newiSum = l.iSum + r.iSum;
		int newlSum = Math.Max(l.lSum, l.iSum + r.lSum);
		int newrSum = Math.Max(r.rSum, l.rSum + r.iSum);
		int newmaxSum = Math.Max(Math.Max(l.maxSum, r.maxSum), l.rSum + r.lSum);
		return new interval(newlSum, newrSum, newiSum, newmaxSum);
	}
	public interval getInfo(int[] arr, int lBound, int rBound)
	{
		if (lBound == rBound) return new interval(arr[lBound], arr[lBound], arr[lBound], arr[lBound]);
		int mid = (lBound + rBound) / 2;
		return merge(getInfo(arr, lBound, mid), getInfo(arr, mid + 1, rBound));
	}
	public int MaxSubArray(int[] nums) => getInfo(nums, 0, nums.Length - 1).maxSum;
}
// @lc code=end