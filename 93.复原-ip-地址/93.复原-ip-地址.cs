/*
 * @lc app=leetcode.cn id=93 lang=csharp
 *
 * [93] 复原 IP 地址
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        if (s.Length > 12 || s.Length < 4)
            return new string[0];
        List<string> addresses = new List<string>();
        foreach (var s1 in ExtractNumber(s))
            if (s1.Item2.Length <= 9)
                foreach (var s2 in ExtractNumber(s1.Item2))
                    if (s2.Item2.Length <= 6)
                        foreach (var s3 in ExtractNumber(s2.Item2))
                            if (s3.Item2.Length > 0
                                && (s3.Item2[0] != '0' || s3.Item2 == "0")
                                && int.TryParse(s3.Item2, out int t)
                                && t <= 255)
                                addresses.Add($"{s1.Item1}.{s2.Item1}.{s3.Item1}.{s3.Item2}");
        return addresses;
    }
    IList<(string, string)> ExtractNumber(string s)
    {
        List<(string, string)> n = new List<(string, string)>();
        if (string.IsNullOrEmpty(s))
            return n;
        if (s[0] == '0')
        {
            n.Add(("0", s[1..]));
            return n;
        }
        n.Add((s[0..1], s[1..]));
        if (s.Length == 1)
            return n;
        n.Add((s[0..2], s[2..]));
        if (s.Length == 2)
            return n;
        if (int.TryParse(s[0..3], out int f) && f <= 255)
            n.Add((s[0..3], s[3..]));
        return n;
    }
}
// @lc code=end
