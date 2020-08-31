/*
 * @lc app=leetcode.cn id=278 lang=csharp
 *
 * [278] 第一个错误的版本
 */

// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
public class Solution : VersionControl
{
	public int FirstBadVersion(int n)
	{
		if (IsBadVersion(1))
			return 1;
		int l = 1, r = n;
		while (r - l > 1)
		{
			int mid = (l + r) / 2;
			if (IsBadVersion(mid))
				r = mid;
			else
				l = mid;
		}
		return r;
	}
}
// @lc code=end