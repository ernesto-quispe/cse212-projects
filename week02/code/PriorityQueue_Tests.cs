using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add 4 elements to the priority queue.
    // Expected Result: count should be 4
    // Defect(s) Found: There wasn't any way to confirm how many elements were in the queue since _queue is internal. Added a method to count the items and return them.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 1);
        priorityQueue.Enqueue("d", 1);
        var total = priorityQueue.CountItems();
        Assert.AreEqual(4, total);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario:  
    // Add 4 items, with increasing priorities, however the last item is the highest priority and should be pulled first from the queue.
    // It should also pull the item from the queue.
    //1. value = a, priority = 1
    //2. value = b, priority = 2
    //3. value = c, priority = 3
    //4. value = d, priority = 4
    // Expected Result: d , 3
    // Defect(s) Found: 
    // it isn't pulling the highest priority if it's the last item in the queue. it wasn't ever reaching the last item in the queue. 
    // It isn't removing the item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 2);
        priorityQueue.Enqueue("c", 3);
        priorityQueue.Enqueue("d", 4);
        var result = priorityQueue.Dequeue();
        var count = priorityQueue.CountItems();
        Assert.AreEqual("d", result);
        Assert.AreEqual(3, count);
        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario:  
    // Add 4 items, with increasing priorities, however the third and last item will have the same priority.
    //1. value = a, priority = 1
    //2. value = b, priority = 2
    //3. value = c, priority = 4
    //4. value = d, priority = 4
    // Expected Result: c 
    // Defect(s) Found: 
    // It is always pulling the higher index Higher priority item. It should pull the item with the first item with the highest priority 
    // It isn't removing the item
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 2);
        priorityQueue.Enqueue("c", 4);
        priorityQueue.Enqueue("d", 4);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("c", result);
    }

    [TestMethod]
    // Scenario:  
    // try to dequeue without adding items should fail
    // Expected Result: "The queue is empty."
    // Defect(s) Found: None, this is working as expected

    public void TestPriorityQueue_4()
    {

        try
        {
            var priorityQueue = new PriorityQueue();
            var result = priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);

        }


    }


}