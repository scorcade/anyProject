// ﻿using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace leedCode
// {
//     internal class _2_______Add_Two_Numbers
//     {
//     }


    //public class Solution
    //{
    //    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    //    {
    //        if (l1 == null && l2 == null && carry == 0) return null;

    //        int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
    //        carry = total / 10;
    //        return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
    //    }
    //}

    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    //public class Solution
    //{
    //    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    //    {
    //        ListNode newNode = new ListNode();
    //        ListNode pNode = newNode;
    //        int nVal = 0;

    //        do
    //        {
    //            int x = l1 == null ? 0 : l1.val;
    //            int y = l2 == null ? 0 : l2.val;
    //            int cVal = x + y + nVal;
    //            nVal = cVal / 10;
    //            cVal = cVal % 10;

    //            pNode.next = new ListNode(cVal);
    //            pNode = pNode.next;
    //            l1 = l1?.next;
    //            l2 = l2?.next;

    //        } while (l1 != null || l2 != null || nVal != 0);

    //        return newNode.next;
    //    }
    
