namespace Solutions;

public static partial class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        var max = 0;
        var current = 0;
        var startIndex = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var span = s.AsSpan(startIndex, i - startIndex);
            var lastCharOccurrence = span.LastIndexOf(s[i]);
            if (lastCharOccurrence >= 0)
            {
                startIndex += lastCharOccurrence + 1;
                current -= lastCharOccurrence;
                continue;
            }
            current++;
            max = current > max ? current : max;
        }

        return max;
    }
}