/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */
using System.Collections.Generic;
// @lc code=start
public class MyStack
{
	Queue<int> q1,q2;
	int top;
	/** Initialize your data structure here. */
	public MyStack()
	{
		q1 = new Queue<int>();
		q2 = new Queue<int>();
		top = 0;
	}

	/** Push element x onto stack. */
	public void Push(int x)
	{
		q1.Enqueue(x);
		top = x;
	}

	/** Removes the element on top of the stack and returns that element. */
	public int Pop()
	{
		while (q1.Count > 1)
		{
			top = q1.Dequeue();
			q2.Enqueue(top);
		}
		int t = q1.Dequeue();
		Queue<int> qt = q1;
		q1 = q2;
		q2 = qt;
		return t;
	}

	/** Get the top element. */
	public int Top() => top;

	/** Returns whether the stack is empty. */
	public bool Empty() => q1.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end