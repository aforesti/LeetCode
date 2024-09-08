// https://leetcode.com/problems/longest-common-prefix/description/
namespace Solutions;

public static partial class Solution {
    public static string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        var prefix = "";
        var equal = true;
        var i = 0;
        while (equal && i < strs[0].Length) {
            var c = strs[0][i];
            equal = strs.Select(s => s.Length > i ? s[i] : ' ').All(s => s == c);
            if (!equal) break;

            prefix += c;
            i++;
        }

        return prefix;
    }
}