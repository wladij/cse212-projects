using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
            var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Low", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue called on empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: No exception or wrong exception message
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }
}