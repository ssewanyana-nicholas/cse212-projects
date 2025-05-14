using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and ensure they are dequeued in priority order.
    // Expected Result: Items are dequeued in priority order (highest priority first).
    // Defect(s) Found: None (if the implementation is correct).
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue<string, int>();
        priorityQueue.Enqueue("Low", 1);    // Priority 1
        priorityQueue.Enqueue("Medium", 2); // Priority 2
        priorityQueue.Enqueue("High", 3);   // Priority 3

        Assert.AreEqual("High", priorityQueue.Dequeue()); // Highest priority first
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with the same priority and ensure FIFO behavior is maintained.
    // Expected Result: Items with the same priority are dequeued in the order they were added.
    // Defect(s) Found: None (if the implementation is correct).
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue<string, int>();
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An exception is thrown.
    // Defect(s) Found: None (if the implementation is correct).
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue<string, int>();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add a single item and remove it.
    // Expected Result: The item is dequeued correctly, and the queue becomes empty.
    // Defect(s) Found: None (if the implementation is correct).
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue<string, int>();
        priorityQueue.Enqueue("OnlyItem", 5);

        Assert.AreEqual("OnlyItem", priorityQueue.Dequeue());
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}