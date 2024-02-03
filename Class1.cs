using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Class1<T>
    {
        Node<T> head;

        public Class1()
        {
            head = null;
        }

        public void AddData(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (head == null)
            {
                head = newnode;
            }
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
                return;

            }
            temp.next = newnode;
            newnode.prev = temp;
        }
        public void AddPrev(T data)
        {
            Node<T> newnode = new Node<T>(data);
            newnode.next = head;
            head.prev = newnode;
            head = newnode;

        }
        public void AddMideAfter(T data)
        {
            Console.WriteLine("Enter a position to Add a data");
            int position = Convert.ToInt32(Console.ReadLine());
            Node<T> newnode = new Node<T>(data);
            Node<T> temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = temp.next;
            }
            newnode.next = temp;
            newnode.prev = temp.prev;
            temp.prev.next = newnode;
            temp.prev = newnode;
        }
        public void deletebegg()
        {
            Node<T> temp = head;
            head = temp.next;
            temp.next.prev = null;
            temp.next = null;
        }
        public void deleteEnd()
        {
            Node<T> temp = head;

            while (temp.next.next != null)
            {
                temp = temp.next;

            }
            temp.next = null;
        }
        public void deleteMiddle()
        {
            Console.WriteLine("Enter the Position of Node you want to delete: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Node<T> temp = head;


            for (int i = 0; i <= position - 2; i++)
            {
                temp = temp.next;
            }
            if (temp.next != null && temp.prev != null)
            {
                temp.prev.next = temp.next;
                temp.next.prev = temp.prev;
                temp.next = null;
                temp.prev = null;

            }
            else if (temp.next != null && temp.prev == null)
            {
                deletebegg();
            }

            else if (temp.next == null && temp.prev != null)
            {
                deleteEnd();
            }

            else
            {
                Console.WriteLine("There is Only One node present");
            }
        }
        public void Print()
        {


            Node<T> temp = head;

            while (temp != null)
            {
                Console.Write($"{temp.data}-> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}






        
