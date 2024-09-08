// https://leetcode.com/problems/two-sum/
namespace Solutions;

public static partial class Solution {
    public static int[] TwoSum(int[] nums, int target)
    {
        for (var i1 = 0; i1 < nums.Length; i1++)
        {
            for (var i2 = i1 + 1; i2 < nums.Length; i2++)
            {
                if (nums[i1] + nums[i2] == target)
                    return [i1, i2];
            }
        }
        return [];
    }
}
