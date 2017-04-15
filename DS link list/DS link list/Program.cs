using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_link_list
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter the data structure");
            //Code
           // Node head;
        }
                class Node
            {
                int data;
                Node next;
                Node(int d)
                {
                    data = d; next = null;

                }
                public static void main(String[] args)
                {
                    /* Start with the empty list. */
                    LinkedList<> llist = new LinkedList();

                    llist.head = new Node(1);
                    Node second = new Node(2);
                    Node third = new Node(3);
                    llist.head.next = second;
                    second.next = third;
                }
            }
        }
    }