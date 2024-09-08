// https://leetcode.com/problems/maximum-distance-in-arrays/?envType=daily-question&envId=2024-08-16
namespace Solutions;

public static partial class Solution {
    public static int MaxDistance(IList<IList<int>> arrays)
    {
        var min = arrays[0][0];
        var max = arrays[0][^1];
        var maxDistance = 0;
        for (var i = 1; i < arrays.Count; i++)
        {
            maxDistance = Math.Max(maxDistance, Math.Max(arrays[i][^1] - min, max - arrays[i][0]));
            min = Math.Min(min, arrays[i][0]);
            max = Math.Max(max, arrays[i].Last());
        }

        return maxDistance;
    }
}
