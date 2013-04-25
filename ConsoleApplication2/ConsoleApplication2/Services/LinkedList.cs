using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Node
    {
        /// <summary>
        ///     The data part of the linked list contains information about object.
        /// </summary>
        public object data;
        /// <summary>
        ///     The link part of the linked list contains information for the next link in the LinkedList.
        /// </summary>
        public Node next;

        /// <summary>
        ///     The method creates a new node in the LinkedList. 
        /// </summary>
        /// <param name="o"></param>
        public Node(object data)
        {
            this.data = data;
        }
    }

    public class LinkedList
    {
        //head of the list all other nodes accessed via this
        public Node head;
        private int lenght = 0;

        public LinkedList() { }
        
        /// <summary>
        ///     Adds an object to the head of the list
        /// </summary>
        /// <param name="newNode"></param>
        public void addAtHead(object newNode)
        {
           Node temp = new Node(newNode);
           temp.next = head;
           head = temp;
           lenght++;
        }
        /// <summary>
        ///     Adds an object to tail of the list
        /// </summary>
        /// <param name="newNode">The object that will be inserted to the Tail of the LinkedList</param>
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
            lenght++;
        }
        /// <summary>
        ///     Search the list for an object
        /// </summary>
        /// <param name="searchTerm">Search Criteria</param>
        /// <returns>Boolean</returns>
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
        ///     The method deletes a node from the LinkedList.
        /// </summary>
        /// <param name="toBeDeleted">The object that will be deleted</param>
        public void delete(object toBeDeleted)
        {
            Node temp = head;
            while (((temp = temp.next) != null) && !(toBeDeleted.Equals(temp.next.data))) ;
            temp.next = temp.next.next;
            lenght--;
        }
        /// <summary>
        ///     The method prints list out to standard output, only for testing purposes and strings.
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
        /// <summary>
        ///     Overide the + operator so it add two list together
        /// </summary>
        /// <param name="lst1">First List</param>
        /// <param name="lst2">Second List</param>
        /// <returns>New First List with Second added on</returns>
        public static LinkedList operator +(LinkedList lst1, LinkedList lst2)
        {
            Node temp = lst1.head;
            if (temp == null)
            {
                lst1.head = lst2.head;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = lst2.head;
            }
            return lst1;
        }
        /// <summary>
        /// return the lenght of list i.e. number of objects in list
        /// </summary>
        /// <returns>number of objects in list</returns>
        public int getLenght()
        {
            return this.lenght;
        }
    }
}
