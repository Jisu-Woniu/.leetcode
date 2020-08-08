/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 *
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}
*/
public class Solution
{
	public ListNode MergeTwoLists(ListNode l1, ListNode l2)
	{
		if (l1 == null) return l2;
		else if (l2 == null) return l1;
		ListNode p1 = l1, p2 = l2;
		ListNode lr, p3;
		if (p1.val <= p2.val)
		{
			lr = new ListNode(l1.val);
			p3 = lr;
			p1 = p1.next;
		}
		else
		{
			lr = new ListNode(l2.val);
			p3 = lr;
			p2 = p2.next;
		}

		while (p1 != null && p2 != null)
		{
			if (p1.val <= p2.val)
			{
				p3.next = new ListNode(p1.val);
				p1 = p1.next;
				p3 = p3.next;
			}
			else
			{
				p3.next = new ListNode(p2.val);
				p2 = p2.next;
				p3 = p3.next;
			}
		}
		if (p1 != null) p3.next = p1;
		else p3.next = p2;
		return lr;
	}
}
// @lc code=end