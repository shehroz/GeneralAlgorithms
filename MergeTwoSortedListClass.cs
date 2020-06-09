using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MergeTwoSortedListClass
    {
        public static ListNode MergeTwoLists_dontuse(ListNode l1, ListNode l2)
        {

            ListNode current = new ListNode(0);
            ListNode result = current;


            while (l1 != null || l2 != null)
            {
                int l1_val = l1 != null ? l1.val : int.MinValue;
                int l2_val = l2 != null ? l2.val : int.MinValue;


                if (l1_val == int.MinValue)
                {
                    int res = l2_val;
                    result.next = new ListNode(res);
                    result = result.next;
                    l2 = l2.next;
                }
                else if (l2_val == int.MinValue)
                {
                    int res = l1_val;
                    result.next = new ListNode(res);
                    result = result.next;
                    l1 = l1.next;
                }
                else if (l1_val < l2_val)
                {
                    int res = l1_val;
                    result.next = new ListNode(res);
                    result = result.next;
                    l1 = l1.next;
                }
                else if (l2_val < l1_val)
                {
                    int res = l2_val;
                    result.next = new ListNode(res);
                    result = result.next;
                    l2 = l2.next;
                }
                else if (l2_val == l1_val)
                {
                    result.next = new ListNode(l1_val);
                    result = result.next;
                    result.next = new ListNode(l2_val);
                    result = result.next;
                    l1 = l1.next;
                    l2 = l2.next;
                }


            }
            return current.next;

        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode current = new ListNode(-1);
            ListNode head = current;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            if (l1 != null)
                current.next = l1;
            else
                current.next = l2;

            return head.next;
        }
    }
}
