using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class linkedlistAddTwoNumbersClass
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currentleft = l1;
            ListNode currentright = l2;
            ListNode result = null;//= new ListNode(0);
            int carry = 0;
            while (currentleft != null && currentright != null)
            {
                int temp = currentleft.val + currentright.val + carry;
                if (result == null)
                    result = new ListNode(temp % 10);
                else
                {
                    ListNode curreslt = result;
                    while (curreslt.next != null)
                    {
                        curreslt = curreslt.next;
                    }
                    ListNode newNode = new ListNode(temp % 10);
                    curreslt.next = newNode;
                }
                carry = temp / 10;
                currentleft = currentleft.next;
                currentright = currentright.next;
            }

            if (carry != 0 && currentleft==null && currentright==null)
            {
                ListNode curreslt = result;
                while (curreslt.next != null)
                {
                    curreslt = curreslt.next;
                }
                ListNode newNode = new ListNode(carry);
                curreslt.next = newNode;
            }

            if (currentleft == null && currentright != null)
            {
                ListNode currentNode = result;
                while (currentright != null)
                {
                    int temp = (carry + currentright.val) % 10;
                    if (currentNode != null)
                        currentNode.next = new ListNode(temp);
                    else
                        currentNode = new ListNode(temp);
                    carry = (carry + currentright.val) / 10;
                    currentright = currentright.next;
                    currentNode = currentNode.next;
                    
                }

                if(carry!=0)
                {
                    ListNode curreslt = result;
                    while (curreslt.next != null)
                    {
                        curreslt = curreslt.next;
                    }
                    ListNode newNode = new ListNode(carry);
                    curreslt.next = newNode;
                }
            }
            else if (currentleft != null && currentright == null)
            {
                ListNode currentNode = result;
                while (currentleft != null)
                {
                    int temp = (carry + currentleft.val) % 10;
                    if (currentNode != null)
                        currentNode.next =  new ListNode(temp);
                    else
                        currentNode = new ListNode(temp);
                    carry = (carry + currentleft.val) / 10;
                    currentleft = currentleft.next;
                    currentNode = currentNode.next;
                    
                }
                if (carry != 0)
                {
                    ListNode curreslt = result;
                    while (curreslt.next != null)
                    {
                        curreslt = curreslt.next;
                    }
                    ListNode newNode = new ListNode(carry);
                    curreslt.next = newNode;
                }
            }


            
            return result;
        }

        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode currenthead = new ListNode(0);
            ListNode result = currenthead;
            int carry = 0;
            while(l1!=null && l2 != null)
            {
                int l1_val1 = (l1 != null) ? l1.val : 0;
                int l2_val2 = (l2 != null) ? l2.val : 0;

                int currentSum = l1.val + l2.val +carry;
                carry = currentSum / 10;
                int remainder = currentSum % 10;

                ListNode newNode = new ListNode(remainder);
                result.next = newNode;
                if (l1!= null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

                result = result.next;
            }

            if (carry > 0)
            {
                ListNode newNode = new ListNode(carry);
                result.next = newNode;
                result = result.next;
            }

            return currenthead;
        }

        public static ListNode AddTwoNumbers3(ListNode l1, ListNode l2)
        {
            ListNode dummy_head = new ListNode(0);
            ListNode l3 = dummy_head;
            int carry = 0;

            while(l1!=null || l2 != null)
            {
                int l1_val = (l1 != null) ? l1.val : 0;
                int l2_val = (l2 != null) ? l2.val : 0;

                int current_sum = l1_val + l2_val + carry;
                carry = current_sum / 10;
                int lastdigit = current_sum % 10;

                ListNode new_Node = new ListNode(lastdigit);
                l3.next = new_Node;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
                l3 = l3.next;
            }
            if (carry > 0)
            {
                ListNode new_node = new ListNode(carry);
                l3.next = new_node;
                l3 = l3.next;
            }

            return dummy_head.next;
        }
    }
}
