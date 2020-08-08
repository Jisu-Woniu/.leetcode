/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
	public ListNode DeleteDuplicates(ListNode head)
	{
		if (head == null || head.next == null) return head;
		ListNode iterator = head;
		while (iterator.next != null)
		{
			while (iterator.next != null && iterator.val == iterator.next.val)
				iterator.next = iterator.next.next;
			if (iterator.next != null)
				iterator = iterator.next;
		}
		return head;
	}
}
// @lc code=end