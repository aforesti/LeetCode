// See https://aka.ms/new-console-template for more information

var s = new Solution(); 
Console.WriteLine(s.RomanToInt("II"));
Console.WriteLine(s.RomanToInt("IV"));
Console.WriteLine(s.RomanToInt("XII"));
Console.WriteLine(s.RomanToInt("IXII"));
Console.WriteLine(s.RomanToInt("MCMXCIX"));
Console.WriteLine(s.RomanToInt("MCMXCIX"));

public class Solution {
    public int RomanToInt(string s) {
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