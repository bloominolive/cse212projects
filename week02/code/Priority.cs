public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        var queue = new PriorityQueue();
        queue.Enqueue("Bob", 1);
        queue.Enqueue("Tim", 1);
        queue.Enqueue("Bill", 1);
        queue.Enqueue("Ted", 1);
        queue.Enqueue("Sue", 3);
        //Console.WriteLine(queue);    // This can be un-commented out for debug help
        while (queue.Length > 0)
            Console.WriteLine(queue.Dequeue());
        // Defect(s) Found: Removed -1 from count as we are evaluating < count
        // Made index < instead of >= high priority index as lower number are greater priority
        // removing the = ensured FIFO

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        var queue2 = new PriorityQueue();
        Console.WriteLine(queue.Dequeue());
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}