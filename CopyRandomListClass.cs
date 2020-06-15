using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class CopyRandomListClass
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
        public static Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            Node copyNodeHead = new Node(head.val);
            map.Add(head, copyNodeHead);
            Node cur = head.next;
            Node CopyList = copyNodeHead;

            while (cur != null)
            {
                CopyList.next = new Node(cur.val);
                map.Add(cur, CopyList.next);
                cur = cur.next;
                CopyList = CopyList.next;
            }

            cur = head.next;
            CopyList = copyNodeHead;
            while (cur != null)
            {
                CopyList.random = cur.random == null ? null : map[cur.random];
                cur = cur.next;
                CopyList = CopyList.next;
            }

            return copyNodeHead;
        }

        public Node CopyRandomList2(Node head)
        {
            if (head == null)
                return null;
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            Node copyNodeHead = new Node(head.val);
            map.Add(head, copyNodeHead);

            Node cur = head.next;
            Node copyList = copyNodeHead;

            while(cur!=null)
            {
                copyList.next = new Node(cur.val);
                map.Add(cur, copyList.next);
                cur = cur.next;
                copyList = copyList.next;
            }
            
            cur = head;
            copyList = copyNodeHead;
            while (cur != null)
            {
                copyList.random = cur.random == null ? null : map[cur.random];
                cur = cur.next;
                copyList = copyList.next;
            }
            
            return copyNodeHead;
        }

        
    }
}
