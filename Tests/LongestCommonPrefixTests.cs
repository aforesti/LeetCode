namespace Tests;

public class LongestCommonPrefixTests
{
    [Fact]
    public void LongestCommonPrefix_AllStringsHaveCommonPrefix_ReturnsCommonPrefix()
    {
        Solution.LongestCommonPrefix(["flower", "flow", "flight"]).Should().Be("fl");
    }

    [Fact]
    public void LongestCommonPrefix_NoCommonPrefix_ReturnsEmptyString()
    {
        Solution.LongestCommonPrefix(["dog", "racecar", "car"]).Should().Be("");
    }

    [Fact]
    public void LongestCommonPrefix_EmptyArray_ReturnsEmptyString()
    {
        Solution.LongestCommonPrefix([]).Should().Be("");
    }

    [Fact]
    public void LongestCommonPrefix_SingleString_ReturnsTheStringItself()
    {
        Solution.LongestCommonPrefix(["single"]).Should().Be("single");
    }

    [Fact]
    public void LongestCommonPrefix_EmptyStrings_ReturnsEmptyString()
    {
        Solution.LongestCommonPrefix(["", "", ""]).Should().Be("");
    }

    [Fact]
    public void LongestCommonPrefix_CommonPrefixWithDifferentLengths_ReturnsCommonPrefix()
    { 
        Solution.LongestCommonPrefix(["ab", "a"]).Should().Be("a");
    }
    
    [Fact]
    public void LongestCommonPrefix_CommonPrefixWithDifferentLengths2_ReturnsCommonPrefix()
    { 
        Solution.LongestCommonPrefix(["a", "ab"]).Should().Be("a");
    }
}