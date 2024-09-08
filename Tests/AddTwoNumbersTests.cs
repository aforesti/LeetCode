namespace Tests;

public class AddTwoNumbersTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void AddTwoNumbers_AddsTwoNumbers(ListNode l1, ListNode l2, ListNode expected)
    {
        var result = Solution.AddTwoNumbers(l1, l2);
        result.Should().BeEquivalentTo(expected);
    }
    
        
        
    public static IEnumerable<object[]> TestData =>
        // Input: l1 = [2,4,3], l2 = [5,6,4]
        // Output: [7,0,8]
        // Explanation: 342 + 465 = 807.
        // 
        // Input: l1 = [0], l2 = [0]
        // Output: [0]
        // 
        // Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        // Output: [8,9,9,9,0,0,0,1]
        new List<object[]>
        {
            new object[] {
                new ListNode(2, new ListNode(4, new ListNode(3))), 
                new ListNode(5, new ListNode(6, new ListNode(4))), 
                new ListNode(7, new ListNode(0, new ListNode(8)))
            },
            new object[] { new ListNode(0), new ListNode(0), new ListNode(0) },
            new object[] {
                new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))),
                new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))),
                new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))))
            }
        };                    
    
}
