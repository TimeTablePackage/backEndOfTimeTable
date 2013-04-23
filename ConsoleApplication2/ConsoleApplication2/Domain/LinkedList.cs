using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Node
    {
        public object data;
        public Node next;
        /// <summary>
        ///     Create a new node 
        /// </summary>
        /// <param name="o"></param>
        public Node(object data)
        {
            this.data = data;
        }
    }

    class LinkedList
    {
        //head of the list all other nodes accessed via this
        public Node head;
        /// <summary>
        ///     Adds an object to the head of the list
        /// </summary>
        /// <param name="newNode"></param>
        public void addAtHead(object newNode)
        {
           Node temp = new Node(newNode);
           temp.next = head;
           head = temp;
        }
        /// <summary>
        ///     Adds an object to tail of the list
        /// </summary>
        /// <param name="newNode"></param>
        public void addAtTail(object newNode)
        {
            Node temp = head;
            if (head == null)
            {
                head = new Node(newNode);
            }
            else
            {
                while ((temp.next) != null)
                {
                    temp = temp.next;
                }
       
                temp.next = new Node(newNode);
            }
        }
        /// <summary>
        ///     Search the list for an object
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public bool searchList(object searchTerm)
        {
            Node temp = head;
            bool answer = false;

            while (((temp = temp.next) != null) && (answer == false))
            {
                if (searchTerm.Equals(temp.data))
                {
                    answer = true;
                }
            }
            return answer;
        }
        /// <summary>
        ///     Delete a node from the list
        /// </summary>
        /// <param name="toBeDeleted"></param>
        public void delete(object toBeDeleted)
        {
            Node temp = head;
            while (((temp = temp.next) != null) && !(toBeDeleted.Equals(temp.next.data))) ;
            temp.next = temp.next.next;
        }

        /// <summary>
        ///     Prints list out to standard output
        ///     really only for testing or strings
        /// </summary>
        public void printList()
        {
            Node temp = head;

            Console.Write(temp.data.ToString() + "\n");
            while ((temp = temp.next) != null)
            {
                Console.Write(temp.data.ToString()+"\n");
            }
        }
    }
}
