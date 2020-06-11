//Class: Software Testing
//Assignment - Unit Testing using C#
//The code written below was not written by me but was a class assignment where we had to remove errors using Unit Testing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
    public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
        public DLList() { head = null; tail = null; } // constructor
        
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        
        public void addToTail(DLLNode p)
        {

            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
                p.previous = tail;
            }
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            //Simplified code by removing "this."
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head.previous = p;
                head = p;
            }
        } // end of addToHead

        public void removeHead()
        {
            //Edited this section of code by simplified it by removing "this."

            //Tested using testRemoveHead2
            if (head == null)
            {
                return;
            }

            else if (head != tail)
            {
                head = head.next;
                head.previous = null;
            }

            else
            {
                head = tail = null;
            }

        } // removeHead

        public void removeTail()
        {
            /* Changed this code as this would not remove the tail
             * Original code:
             * if (this.head == this.tail)
             * {
             * this.head = null;
             * this.tail = null;
             * return;
             * }
             * To this below: */

            if (head == null)
            {
                return;
            }
            else if (head != tail)
            {
                tail = tail.previous;
                tail.next = null;
            }
            else
            {
                head = tail = null;
            }
        } // remove tail

        public DLLNode search(int num)
        {
            DLLNode p = head;
            
            if(head == null)
            {
                return null;
            }
            
            while (p != null)
            {

                if (p.num == num)
                {
                    return (p);
                }

                p = p.next;
            }
            return null;
        } // end of search (return pionter to the node);

        public void removeNode(DLLNode p)
        { // removing the node p.

            /* Cleaned this section, as I felt this code was too complicated for what it was trying to do.
             * Replaced with the following code: (Previous code used is commented out)*/

            DLLNode node = head;

            while (node.num != p.num)
            {
                //Tested using testRemoveNode1
                if (node.next == null)
                {
                    /* Original code:
                     * this.tail = this.tail.previous;
                     * this.tail.next = null;
                     * p.previous = null;
                     * return;*/
                    return;
                }
                else
                {
                    /* Original code:
                     * this.head = this.head.next;
                     * p.next = null;
                     * this.head.previous = null;
                     * return;*/

                    //Tested using testRemoveNode2
                    node = node.next;
                }
            }

            //Tested using testRemoveNode3
            if (node == head)
            {
                removeHead();
            }

            //Tested using testRemoveNode4
            else if (node == tail)
            {
                removeTail();
            }

            else
            {
                //Tested using testRemoveNode2
                node.previous.next = node.next;
                node.next.previous = node.previous;
            }

        } // end of remove a node

        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                /* Original code:
                 * tot += p.num;
                 * p = p.next.next;
                 *
                 * Changed to the code below :*/
                p = p.next;
                tot++;
            }
            return (tot);
        } // end of total
    } // end of DLList class
}
