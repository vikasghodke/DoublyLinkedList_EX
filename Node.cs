using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node<T>
    {
        public int data;
        public Node<T> next;
        public Node<T> prev;

        public Node(T data)
        {
            data = data;
            next = null;
            prev = null;
        }

    }
}
