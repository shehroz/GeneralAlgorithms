using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericAlgorithms
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }
        public T Peek()
        {
            T frontItem = data[0];
            data.Remove(frontItem);
            return frontItem;
        }
        public int Count()
        {
            return data.Count;
        }
        public void Enqueue(T item)
        {
            data.Add(item);
            data.Sort();
            //int ci = data.Count - 1;
            //while (ci > 0)
            //{
            //    int pi = (ci - 1) / 2;
            //    if (data[ci].CompareTo(data[pi]) >= 0)
            //        break;
            //    T tmp = data[ci];
            //    data[ci] = data[pi];
            //    data[pi] = tmp;
            //    ci = pi;
            //}
        }
    }

    public class MergeKListsClass
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            foreach (ListNode item in lists)
            {
                ListNode curItem = item;
                while (curItem != null)
                {
                    queue.Enqueue(curItem.val);
                    curItem = curItem.next;
                }
            }

            ListNode current = new ListNode(-1);
            ListNode head = current;
            while (queue.Count() != 0)
            {
                current.next = new ListNode(queue.Peek());
                current = current.next;
            }
            return head.next;

        }
        public static ListNode SortedMerge(ListNode a, ListNode b)
        {
            ListNode result = null;

            /* Base cases */
            if (a == null)
                return b;
            else if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.val <= b.val)
            {
                result = a;
                result.next = SortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = SortedMerge(a, b.next);
            }

            return result;
        }
        public static ListNode mergeKLists(ListNode[] arr, int last)
        {
            // repeat until only one list is left  
            while (last != 0)
            {
                int i = 0, j = last;

                // (i, j) forms a pair  
                while (i < j)
                {
                    // merge List i with List j and store  
                    // merged list in List i  
                    arr[i] = SortedMerge(arr[i], arr[j]);

                    // consider next pair  
                    i++; j--;

                    // If all pairs are merged, update last  
                    if (i >= j)
                        last = j;
                }
            }

            return arr[0];
        }
    }
    
}
