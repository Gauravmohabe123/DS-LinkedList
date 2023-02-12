using System;
using System.Collections.Generic;
using System.Text;

namespace linked_list
{
    internal class Linkedlist
    {
        internal class UnsortedList<T>
        {
            private Node head;
            public class Node
            {
                public T data;
                public Node Next;
                public Node(T data)
                {
                    this.data = data;
                }
            }

            public bool Add(T data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                    return true;
                }
                node.Next = head;
                head = node;
                return true;
            }
            public override string ToString()
            {
                if (head == null)
                {
                    return null;
                }
                Node t = head;
                string a = "";
                while (t != null)
                {
                    a = a + t.data + " ";
                    t = t.Next;
                }
                return a;
            }
        }
    }
}
