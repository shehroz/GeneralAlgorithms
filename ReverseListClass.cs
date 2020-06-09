using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ReverseListClass
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode newnode = head.next;
                head.next = prev;
                prev = head;
                head = newnode;
            }
            return prev;
        }
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null)
                return null;
            ListNode prev = null;
            ListNode currentnode = head;
            while (m > 1)
            {
                prev = currentnode;
                currentnode = currentnode.next;
                m--;
                n--;
            }
            ListNode connection = prev;
            ListNode tail = currentnode;

            while (n > 0)
            {
                ListNode next_node = currentnode.next;
                currentnode.next = prev;
                prev = currentnode;
                currentnode = next_node;
                n--;
            }
            if (connection != null)
            {
                connection.next = prev;
            }
            else
            {
                head = prev;
            }
            tail.next = currentnode;
            return head;

        }
    }

}
