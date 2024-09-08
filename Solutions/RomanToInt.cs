// https://leetcode.com/problems/roman-to-integer/description/
namespace Solutions;

public partial class Solution {
    public static int RomanToInt(string s) {
        var sum = 0;
        for (var i = 0; i < s.Length; i++ )
        {
            var nextChar = i == s.Length - 1 ? null : (char?)s[i + 1];
            sum += s[i] switch
            {
                'M' => 1000,
                'D' => 500,
                'C' when nextChar is 'M' or 'D' => -100,
                'C' => 100,
                'L' => 50,
                'X' when nextChar is 'C' or 'L' => -10,
                'X' => 10,
                'V' => 5,
                'I' when nextChar is 'X' or 'V' => -1,
                'I' => 1,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        return sum;
    }
}