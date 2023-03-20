using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Singly
    {
        public Node head;
        public Node tail;
        public int size;


        public Node CreateSinglyLinkedList(int value)
        {
            head = new Node();
            Node node = new Node();
            node.value = value;
            node.Next = null;
            head= node;
            tail= node;
            size = 1;
            return node;

        }
    }
}
