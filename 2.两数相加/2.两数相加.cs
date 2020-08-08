/*
 * @lc app=leetcode.cn id=2 lang=csharp
 *
 * [2] 两数相加
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
public class Solution {
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
		ListNode lr = new ListNode(0);
		ListNode pointer = lr;
		int currentSum = l1.val + l2.val + pointer.val;
		pointer.val = currentSum % 10;
		while (l1.next != null && l2.next != null)
		{
			pointer.next = new ListNode(currentSum / 10);
			l1 = l1.next; l2 = l2.next; pointer = pointer.next;
			currentSum = l1.val + l2.val + pointer.val;
			pointer.val = currentSum % 10;
		}
		while (l1.next != null)
		{
			pointer.next = new ListNode(currentSum / 10);
			l1 = l1.next; pointer = pointer.next;
			currentSum = l1.val + pointer.val;
			pointer.val = currentSum % 10;
		}
		while (l2.next != null)
		{
			pointer.next = new ListNode(currentSum / 10);
			l2 = l2.next; pointer = pointer.next;
			currentSum = l2.val + pointer.val;
			pointer.val = currentSum % 10;
		}
		if (currentSum >= 10)
			pointer.next = new ListNode(currentSum / 10);
		return lr;
	}
}
// @lc code=end

