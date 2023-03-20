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

        public void insertValueInLinkedList(int value, int location)
        {
            //insert at the begining of a linked List
            //check if the list is created
            Node node = new Node();
            node.value = value;
            if(head == null)
            {
                CreateSinglyLinkedList(value);
            }
            else if(location == 0)
            {
                node.Next = head;
                head = node;

            }else if(location >=size )
            {
                Node lastNode = tail.Next;
                node.Next = null;
                tail = node;
                lastNode = node;

            }
            else
            {
                Node tempNode = head;
                int count = 0;
                while(count <location - 1)
                {
                    tempNode = tempNode.Next;
                    count++;
                }
                Node NextNode = tempNode.Next;
                node.Next = NextNode;
                tempNode.Next = node;
            }
            size++;


        }
    }
}
