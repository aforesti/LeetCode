namespace Tests;

public class TwoSumTests
{
    [Fact]
    public void TwoSum_ReturnsIndicesOfTwoNumbers()
    {
        // Input: nums = [2,7,11,15], target = 9
        // Output: [0,1]
        // Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;
        var result = Solution.TwoSum(nums, target);
        result.Should().BeEquivalentTo(new[] { 0, 1 });

        // Input: nums = [3,2,4], target = 6
        // Output: [1,2]
        // Output: Because nums[1] + nums[2] == 6, we return [1, 2].
        nums = [3, 2, 4];
        target = 6;
        result = Solution.TwoSum(nums, target);
        result.Should().BeEquivalentTo(new[] { 1, 2 });
    }
}