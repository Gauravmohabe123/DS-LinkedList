using System;
using System.Collections.Generic;
using System.Text;

namespace linked_list
{
   public  class Linkedlist
    {
        public class Linkedist<T>
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
           
        }
    }
}
