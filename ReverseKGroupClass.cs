using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ReverseKGroupClass
    {
        //public class ListNode
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int val = 0, ListNode next = null)
        //    {
        //        this.val = val;
        //        this.next = next;
        //    }
        //}
        
        public static bool hasNodes(ListNode cur, int k)
        {
            while (k > 0 && cur != null)
            {
                k--;
                cur = cur.next;
            }
            return k == 0;
        }
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode prev = null;
            ListNode startingPoint = head;
            int count = 0;
            while (head != null && count < k)
            {
                ListNode newNode = head.next;
                head.next = prev;
                prev = head;
                head = newNode;
                count++;
            }
            if (hasNodes(head, k))
                startingPoint.next = ReverseKGroup(head, k);
            else
                startingPoint.next = head;

            return prev;

        }
    }
}
