https://leetcode.com/problems/kth-largest-element-in-a-stream/description/

public class KthLargest {

    private readonly List<int> _nums;
    private readonly int _k;

    public KthLargest(int k, int[] nums) {
        _nums = new List<int>(nums);
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
