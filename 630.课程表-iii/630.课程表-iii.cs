/*
 * @lc app=leetcode.cn id=630 lang=csharp
 *
 * [630] 课程表 III
 */
using System;
using System.Collections.Generic;
// @lc code=start
class PriorityQueue<T>
{
	private SortedSet<T> list;
	private Dictionary<T, int> dict;
	private int count;

	public PriorityQueue()
	{
		list = new SortedSet<T>();
		dict = new Dictionary<T, int>();
	}
	public bool IsEmpty => list.Count == 0;

	public int Count { get => count;}

	public void Add(T item)
	{
		count++;
		if (dict.ContainsKey(item))
			dict[item]++;
		else
		{
			list.Add(item);
			dict.Add(item, 1);
		}
	}

	public T PeekMax() => list.Max;

	public T PopMax()
	{
		count--;
		T ret = PeekMax();
		if (dict[ret] == 1)
		{
			dict.Remove(ret);
			list.Remove(ret);
		}
		else
			dict[ret]--;
		return ret;
	}
}
public class Solution
{
	public int ScheduleCourse(int[][] courses)
	{
		Array.Sort(courses, (a, b) => a[1] - b[1]);
		PriorityQueue<int> queue = new PriorityQueue<int>();
		int day = 0;
		foreach(int[] course in courses)
		{
			if (day + course[0] <= course[1])
			//day+duration<=deadline
			{
				queue.Add(course[0]);
				day += course[0];
			}
			else if (!queue.IsEmpty && queue.PeekMax() > course[0])
			{
				day += course[0] - queue.PopMax();
				queue.Add(course[0]);
			}
		}
		return queue.Count;
	}
}
// @lc code=end