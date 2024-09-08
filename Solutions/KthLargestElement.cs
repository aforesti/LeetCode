// https://leetcode.com/problems/kth-largest-element-in-a-stream/description/

/*
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */

namespace Solutions;

public static partial class Solution
{
    public static int?[] KthLargestElement(int[] nums, int k, params int[] add)
    {
        var kthLargest = new KthLargest(k, nums);
        var result = new List<int?>();
        foreach (var a in add)
        {
            result.Add(kthLargest.Add(a));
        }

        return result.ToArray();
    }
}


public class KthLargest {

    private readonly List<int> _nums;
    private readonly int _k;

    public KthLargest(int k, int[] nums) {
        _nums = [..nums];
        _nums.Sort();
        _k = k;
    }

    public int Add(int val)
    {
        var index = _nums.BinarySearch(val);
        if (index < 0) index = ~index;
        _nums.Insert(index, val);

        while (_nums.Count > _k)
        {
            _nums.RemoveAt(0);
        }
        return _nums[0];
    }
}