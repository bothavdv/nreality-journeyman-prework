using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures
{
    [TestClass]
    public class UnitTestForList
    {
        //Lists are ideal for directly accessing and storing contents, when working with large amounts of data, these data structures are often sub-optimal candidates when the data needs to be searched
        //wrapper for an array, providing read/write access to the array and automatically resizing the array as needed
        //the List class, like an array, is a homogeneous data structure, meaning that you can only store items of the same type or from a derived type within a given List
        [TestMethod]
        public void TestReadFromListOrdinal()
        {
            var powersOf2 = new MyOwnList<int>();
            powersOf2.Add(1);
            Assert.AreEqual(powersOf2[0], 1);
        }
        
        [TestMethod]
        public void TestWriteToListOrdinal()
        {
            var powersOf2 = new MyOwnList<int>();
            powersOf2.Add(1);
            powersOf2.Add(2);

            // Change the 2nd List item to 10
            powersOf2[1] = 10;
            Assert.AreEqual(powersOf2[1], 10);
        }

        [TestMethod]
        public void TestBinarySearchOnList()
        {
            var powersOf2 = new MyOwnList<string>();
            powersOf2.Add("100");
            powersOf2.Add("9");
            var dc = new MyOwnListComparer();
            Assert.AreEqual(0, powersOf2.BinarySearch("9", dc));
        }

        //List cousin, the Queue and stack is specialized lists providing storage for a variable number of objects, but restricting the order in which the items may be accessed.
        //  add from rear - enqueu, remove from rear - dequeue FIFO
        //  queue can be empty and have to upper limit
        //  Queue overflow results from trying to add an element onto a full queue and queue underflow happens when trying to remove an element from an empty queue

        // asymptotic running time is determined by the amount of times you need to access the array when performing a search and is denoted as O(n) [big-Oh]
        // Others include O(log2 n), O(n log2 n), O(n2), O(2n)... an operation that runs in O(log n) is more efficient than one that runs in O(n) since log n < n

        [TestMethod]
        public void TestMethodQueue()
        {

        }
    }
}
