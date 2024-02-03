using DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class Program
    {
        static void Main()
        {
            Class1<int> c1 = new Class1<int>();
            c1.AddData(23);
            c1.AddData(90);
            c1.AddPrev(56);
            c1.AddPrev(3);
            c1.AddPrev(6);
            c1.AddMideAfter(89);
            c1.AddPrev(78);
            c1.AddData(3);
            c1.AddPrev(8);
            c1.AddMideAfter(5);
            c1.deleteMiddle();
            c1.deletebegg();
            c1.Show();

           

        }
    }
}