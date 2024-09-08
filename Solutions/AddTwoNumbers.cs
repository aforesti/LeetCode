// https://leetcode.com/problems/add-two-numbers/description/
namespace Solutions;

/**
 * Definition for singly-linked list.*/
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static partial class Solution {
    public static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var firstNode = new ListNode();
        var result = firstNode;
        var carry = 0;
        while (l1 != null || l2 != null || carry > 0)
        {
            var firstNumber = l1?.val ?? 0;
            var secondNumber = l2?.val ?? 0;
            var sum = firstNumber + secondNumber + carry;
            carry = sum / 10;
            result.val = sum % 10;

            l1 = l1?.next;
            l2 = l2?.next;

            if (l1 == null && l2 == null && carry <= 0) continue;
            result.next = new ListNode();
            result = result.next;
        }
        return firstNode;
    }
}