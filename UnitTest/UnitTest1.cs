//Written by Rewa Hill
//Class: Software Testing
//Assignment - Unit Testing using C#
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Testing of total of nodes
        //Tests no nodes in list
        [TestMethod]
        public void testTotal1()
        {
            DLList list = new DLList();

            Assert.AreEqual(list.total(), 0);
        }

        //Tests 2 total of 2 nodes in list
        [TestMethod]
        public void testTotal2()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(6);
            list.addToTail(node1);
            list.addToTail(node2);

            Assert.AreEqual(list.total(), 2);
        }

        //Tests node being added to tail
        //Tests adding 1 node to tail
        [TestMethod]
        public void testAddToTail1()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(12);
            list.addToTail(node);

            Assert.AreEqual(list.total(), 1);
            Assert.AreEqual(node, list.tail);
        }

        //Tests adding 5 nodes to tail
        [TestMethod]
        public void testAddToTail2()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(6);
            DLLNode node4 = new DLLNode(8);
            DLLNode node5 = new DLLNode(1);

            list.addToTail(node1);
            list.addToTail(node2);
            list.addToTail(node3);
            list.addToTail(node4);
            list.addToTail(node5);

            Assert.AreEqual(list.total(), 5);
            Assert.AreEqual(node5, list.tail);
        }

        //Tests node being added to head
        //Tests 1 node being added to head
        [TestMethod]
        public void testAddToHead1()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(12);
            list.addToHead(node1);

            Assert.AreEqual(list.total(), 1);
        }

        //Tests 5 nodesbeing added to head
        [TestMethod]
        public void testAddToHead2()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(6);
            DLLNode node4 = new DLLNode(8);
            DLLNode node5 = new DLLNode(1);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);
            list.addToHead(node5);

            Assert.AreEqual(list.total(), 5);
            Assert.AreEqual(node5, list.head);
        }

        //Tests for removal of head node
        //Tests removing head from list
        [TestMethod]
        public void testRemoveHead1()
        {
            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(7);

            DLList list = new DLList();

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.removeHead();

            Assert.AreEqual(list.total(), 2);
            Assert.AreEqual(node2, list.head);
        }

        //Tests removing head where list has 1 node
        [TestMethod]
        public void testRemoveHead2()
        {
            DLLNode node = new DLLNode(12);

            DLList list = new DLList();

            list.addToHead(node);
            list.removeHead();

            Assert.AreEqual(list.total(), 0);
            Assert.IsNull(list.head);
        }

        //Tests for removal of tail node
        //Tests removal of tail from list
        [TestMethod]
        public void testRemoveTail1()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.removeTail();

            Assert.AreEqual(list.total(), 2);
            Assert.AreEqual(node2, list.tail);
        }

        //Tests removal of tail from list with 1 node
        [TestMethod]
        public void testRemoveTail2()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(5);

            list.addToTail(node);

            list.removeTail();

            Assert.AreEqual(list.total(), 0);
            Assert.AreEqual(list.tail, null);
        }

        //Tests for a value in the list
        //Tests searching for node in a list
        [TestMethod]
        public void testSearch1()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(7);
            DLLNode node3 = new DLLNode(20);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);

            Assert.AreEqual(list.search(5), node1);
        }

        //Tests for searches not listed
        [TestMethod]
        public void testSearch2()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(7);
            DLLNode node3 = new DLLNode(1);
            DLLNode node4 = new DLLNode(16);


            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);

            Assert.IsNull(list.search(20));
        }

        //Tests removal of a node
        //Removes a node from a list where there is 1 node
        [TestMethod]
        public void testRemoveNode1()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(12);

            list.addToHead(node);
            list.removeNode(node);

            Assert.AreEqual(list.total(), 0);
            Assert.IsNull(list.head);
        }

        //Removes a node from the middle of the list
        [TestMethod]
        public void testRemoveNode2()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);

            list.removeNode(node2);

            Assert.AreEqual(list.total(), 2);
            Assert.AreEqual(list.head, node3);
            Assert.AreEqual(list.tail, node1);
        }

        //Removes node from the tail of the list
        [TestMethod]
        public void testRemoveNode3()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);

            list.removeNode(node1);

            Assert.AreEqual(list.total(), 2);
            Assert.AreEqual(list.tail, node2);
        }

        //Removes node from the head of the list
        [TestMethod]
        public void testRemoveNode4()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(12);
            DLLNode node2 = new DLLNode(5);
            DLLNode node3 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);

            list.removeNode(node3);

            Assert.AreEqual(list.total(), 2);
            Assert.AreEqual(list.head, node2);
        }

        //Tests Prime Numbers
        //Tests boundary conditions
        [TestMethod]
        public void testPrimeNumber1()
        {
            int num = 2;
            DLLNode node = new DLLNode(num);

            Assert.IsTrue(node.isPrime(num));
        }

        [TestMethod]
        public void testPrimeNumber2()
        {
            int num = 3;
            DLLNode node = new DLLNode(num);

            Assert.IsTrue(node.isPrime(num));
        }

        //Tests for non-prime numbers using square root
        [TestMethod]
        public void testPrimeNumber3()
        {
            int num = 49;
            DLLNode node = new DLLNode(num);

            Assert.IsFalse(node.isPrime(num));
        }

        //Tests non-prime numbers boundary condition
        [TestMethod]
        public void testPrimeNumber4()
        {
            int num = 1;
            DLLNode node = new DLLNode(num);

            Assert.IsFalse(node.isPrime(num));
        }
    }
}
