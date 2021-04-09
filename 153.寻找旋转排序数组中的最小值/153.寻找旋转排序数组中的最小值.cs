/*
 * @lc app=leetcode.cn id=153 lang=csharp
 *
 * [153] 寻找旋转排序数组中的最小值
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1, p = nums[r];
        while (l < r)
        {
            int mid = (l + r) >> 1;
            if (nums[mid] <= p)
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }
        return nums[l];
    }
}
// @lc code=end

