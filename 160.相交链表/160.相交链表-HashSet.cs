/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
 */
using System.Collections.Generic;
// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/*public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}*/
public class Solution
{
	public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
	{
		if (headA == null || headB == null) return null;
		HashSet<ListNode> setA = new HashSet<ListNode>() { headA };
		HashSet<ListNode> setB = new HashSet<ListNode>() { headB };
		ListNode pA = headA, pB = headB;
		while (!(setA.Contains(pB) || setB.Contains(pA)))
		{
			if (pA.next == null && pB.next == null) return null;
			if (pA.next != null)
			{
				pA = pA.next;
				setA.Add(pA);
			}
			if (pB.next != null)
			{
				pB = pB.next;
				setB.Add(pB);
			}
		}
		if (setA.Contains(pB)) return pB;
		else return pA;
	}
}
// @lc code=end