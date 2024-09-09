using FluentAssertions.Execution;

namespace Tests;

public class LengthOfLongestSubstringTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("aab", 2)]
    [InlineData("dvdf", 3)]
    [InlineData("aabaab!b", 3)]
    public void LengthOfLongestSubstring_ReturnsCorrectLength(string s, int expected)
    {
        Solution.LengthOfLongestSubstring(s).Should().Be(expected);
    }
}