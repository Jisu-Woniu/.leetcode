/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */
using System.Collections.Generic;
// @lc code=start
public class MyStack
{
	Queue<int> q;
	/** Initialize your data structure here. */
	public MyStack()
	{
		q = new Queue<int>();
	}

	/** Push element x onto stack. */
	public void Push(int x)
	{
		Queue<int> qt = new Queue<int>();
		qt.Enqueue(x);
		while (q.Count > 0)
			qt.Enqueue(q.Dequeue());
		q = qt;
	}

	/** Removes the element on top of the stack and returns that element. */
	public int Pop()
	{
		return q.Dequeue();
	}

	/** Get the top element. */
	public int Top()
	{
		return q.Peek();
	}

	/** Returns whether the stack is empty. */
	public bool Empty()
	{
		return q.Count == 0;
	}
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