namespace cSharp;

class Queue
{

    // Create a Queue that stores strings
    // Add three strings in queue
    // Write a method that removes the first string in the queue and writes it to the console
    // Add two more strings and repeate remove until the queue is empty
    // Use the methods Enqueu and Dequeue

    Queue<string> queue = new Queue<string>();

    public Queue()
    {

    }

    public void modifyQueue()
    {
        Console.WriteLine("Original Queue: ");

        queue.Enqueue("Spoon");
        queue.Enqueue("Fork");
        queue.Enqueue("Knife");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        //queue.Dequeue();

        Console.WriteLine("\nDequeued Queue: ");

        while (queue.Count > 0)
        {
            var dequeueItem = queue.Dequeue();
            Console.WriteLine(dequeueItem);
        }

        Console.WriteLine("\nUpdated Queue: ");

        queue.Enqueue("Plate");
        queue.Enqueue("Cup");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
