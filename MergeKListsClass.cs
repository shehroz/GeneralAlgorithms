﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericAlgorithms
{
    public class MergeKListsClass
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;
            return Merge(lists, 0, lists.Length -1);
        }
        private ListNode Merge(ListNode[] lists,int i,int j)
        {
            if (i == j)
                return lists[i];
            else
            {
                int mid = i + (j - i) / 2;
                ListNode left = Merge(lists, i, mid);
                ListNode right = Merge(lists, mid + 1, j);

                return Merge(left, right);
            }
        }
        private ListNode Merge(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(0),
                cur = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    cur.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    cur.next = list2;
                    list2 = list2.next;
                }
                cur = cur.next;
            }

            if (list1 != null)
                cur.next = list1;
            else
                cur.next = list2;

            return dummy.next;
        }
    }
    
}
