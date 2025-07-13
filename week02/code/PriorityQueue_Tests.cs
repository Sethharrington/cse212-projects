using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with all values containing the same priority.
    // Expected Result: Albert, Beto, Carlos, Diana, Erica, Fabio, Gabriela, Henrique
    // Defect(s) Found: If several items would have the same priority, it takes LIFO policy to delete it instead of FIFO.
    public void TestPriorityQueue_1()
    {
        string[] expectedResult = ["Albert", "Beto", "Carlos", "Diana", "Erica", "Fabio", "Gabriela", "Henrique"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Albert", 1);
        priorityQueue.Enqueue("Beto", 1);
        priorityQueue.Enqueue("Carlos", 1);
        priorityQueue.Enqueue("Diana", 1);
        priorityQueue.Enqueue("Erica", 1);
        priorityQueue.Enqueue("Fabio", 1);
        priorityQueue.Enqueue("Gabriela", 1);
        priorityQueue.Enqueue("Henrique", 1);
        for (int i = 0; i < expectedResult.Length; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the order of priority inverted against the order of enqueuing.
    // Expected Result: Erica, Diana, Carlos, Beto, Albert
    // Defect(s) Found: The last value (Erica) of the queue was not being compared in the priority check for each value.
    public void TestPriorityQueue_2()
    {
        string[] expectedResult = ["Erica", "Diana", "Carlos", "Beto", "Albert"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Albert", 1);
        priorityQueue.Enqueue("Beto", 2);
        priorityQueue.Enqueue("Carlos", 3);
        priorityQueue.Enqueue("Diana", 4);
        priorityQueue.Enqueue("Erica", 5);

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the order of priority equal to the order of enqueuing.
    // Expected Result: Albert, Beto, Carlos, Diana, Erica
    // Defect(s) Found: No problems
    public void TestPriorityQueue_3()
    {
        string[] expectedResult = ["Albert", "Beto", "Carlos", "Diana", "Erica"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Albert", 5);
        priorityQueue.Enqueue("Beto", 4);
        priorityQueue.Enqueue("Carlos", 3);
        priorityQueue.Enqueue("Diana", 2);
        priorityQueue.Enqueue("Erica", 1);

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }
    [TestMethod]
    // Scenario: Create a queue with pairs of priority to check the order of dequeing.
    // Expected Result: Gabriela, Beto, Erica, Fabio, Carlos, Diana, Henrique, Albert
    // Defect(s) Found: All good, working as expected.
    public void TestPriorityQueue_5()
    {
        string[] expectedResult = [
            "Gabriela",
            "Beto",
            "Erica",
            "Fabio",
            "Carlos",
            "Diana",
            "Henrique",
            "Albert",
             ];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Albert", 1);
        priorityQueue.Enqueue("Beto", 1);
        priorityQueue.Enqueue("Carlos", 2);
        priorityQueue.Enqueue("Diana", 2);
        priorityQueue.Enqueue("Erica", 3);
        priorityQueue.Enqueue("Fabio", 3);
        priorityQueue.Enqueue("Gabriela", 4);
        priorityQueue.Enqueue("Henrique", 4);
        for (int i = 0; i < expectedResult.Length; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }
}