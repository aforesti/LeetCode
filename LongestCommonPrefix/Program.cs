// See https://aka.ms/new-console-template for more information

var s = new Solution();


Console.WriteLine(s.LongestCommonPrefix(["a"]));
Console.WriteLine(s.LongestCommonPrefix(["flower","flow","flight"]));


public class Solution {
    public string LongestCommonPrefix(string[] strs) {
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