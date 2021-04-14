/*
 * @lc app=leetcode.cn id=208 lang=csharp
 *
 * [208] 实现 Trie (前缀树)
 */

// @lc code=start
public class Trie
{
	Trie[] branches;
	bool isEnd;
	/** Initialize your data structure here. */
	public Trie()
	{
		branches = new Trie[26];
		isEnd = false;
	}

	/** Inserts a word into the trie. */
	public void Insert(string word)
	{
		Trie current = this;
		foreach (char c in word)
		{
			current.branches[c - 'a'] ??= new Trie();   // if (current.branches[c - 'a'] == null) current.branches[c - 'a'] = new Trie();
			current = current.branches[c - 'a'];
		}
		current.isEnd = true;
	}

	/** Returns if the word is in the trie. */
	public bool Search(string word)
	{
		return SearchPrefix(word) is { isEnd: true };   // result != null && result.isEnd
	}

	/** Returns if there is any word in the trie that starts with the given prefix. */
	public bool StartsWith(string prefix) => SearchPrefix(prefix) != null;

	Trie SearchPrefix(string prefix)
	{
		Trie current = this;
		foreach (char c in prefix)
		{
			if (current.branches[c - 'a'] == null)
			{
				return null;
			}
			current = current.branches[c - 'a'];
		}
		return current;
	}
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end