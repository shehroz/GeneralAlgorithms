using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    //Partision Linked list
    public class PartitionClass
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
                return null;
            ListNode left = new ListNode(0);
            ListNode lefthead = left;
            ListNode right = new ListNode(0);
            ListNode righthead = right;

            while (head != null)
            {
                if (head.val < x)
                {
                    left.next = head;
                    left = left.next;
                }
                else
                {
                    right.next = head;
                    right = right.next;
                }
                head = head.next;
            }
            right.next = null;
            left.next = righthead.next;
            return lefthead.next;
        }

        public static ListNode Partition_SafeSpace(ListNode head, int x)
        {
            if (head == null)
                return head;
            else if (head.next == null)
                return head;

            head.next = Partition_SafeSpace(head.next, x);
            if (head.val < x)
                return head;
            else
            {
                ListNode current = head;
                while (current.next != null)
                {
                    if (current.val > current.next.val && current.next.val < x)
                    {
                        int temp = current.val;
                        current.val = current.next.val;
                        current.next.val = temp;
                        current = current.next;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            return head;


        }

       
    }
}
