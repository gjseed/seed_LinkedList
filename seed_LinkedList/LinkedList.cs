﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seed_LinkedList
{
    class LinkedList
    {
        private Node head;
        public Node addToEnd(string data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
                return current.next;
            }

        }

        public Node addToFront(string data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = head;
                }            
                head = new Node(data);
                return head;
            }

        }

        public void Contains()
        {
            //search code
        }

        public void Remove()
        {
            Node current = head;
            if(head != null)
            {
                current = null;
            }
            current = current.next;
        }

        public void getFirst()
        {
            Node current = head;
            if(head == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine(current.data);
            }
        }

        public void Print()
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }
    }
}
