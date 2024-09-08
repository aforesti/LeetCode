namespace Tests;

public class KthLargestElementTests
{
    [Theory]
    [InlineData(new int[] { 4, 5, 8, 2 }, 3, new int[] { 3 }, new[] { 4 })]
    [InlineData(new int[] { 4, 5, 8, 2 }, 3, new int[] { 3, 5 }, new[] { 4, 5 })]
    [InlineData(new int[] { 4, 5, 8, 2 }, 3, new int[] { 3, 5, 10 }, new[] { 4, 5, 5 })]
    [InlineData(new int[] { 4, 5, 8, 2 }, 3, new int[] { 3, 5, 10, 9 }, new[] { 4, 5, 5, 8 })]
    [InlineData(new int[] { 4, 5, 8, 2 }, 3, new int[] { 3, 5, 10, 9, 4 }, new[] { 4, 5, 5, 8, 8 })]
    public void KthLargestElement_ReturnsCorrectKthLargest(int[] nums, int k, int[] add, int[] expected)
    { 
        Solution.KthLargestElement(nums, k, add).Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(new int[] { }, 1, new int[] { 1 }, new[] { 1 })]
    [InlineData(new int[] { }, 1, new int[] { 1, 2 }, new[] { 1, 2 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 2 }, new[] { 2 })]
    [InlineData(new int[] { 1 }, 2, new int[] { 2 }, new[] { 1 })]
    public void KthLargestElement_HandlesEmptyAndSingleElementArrays(int[] nums, int k, int[] add, int[] expected)
    {
        Solution.KthLargestElement(nums, k, add).Should().BeEquivalentTo(expected);
    }
    
}