namespace Tests;

public class RomanToIntTests
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VI", 6)]
    [InlineData("VII", 7)]
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    [InlineData("XI", 11)]
    [InlineData("L", 50)]
    [InlineData("XCV", 95)]
    [InlineData("CCCXLI", 341)]
    [InlineData("MCMXCIX", 1999)]
    [InlineData("MMXXI", 2021)]
    [InlineData("MMMCMXCIX", 3999)]
    [InlineData("MMMM", 4000)]
    
    public void RomanToIntTest(string roman, int expected)
    {
        Solution.RomanToInt(roman).Should().Be(expected);
    }
}