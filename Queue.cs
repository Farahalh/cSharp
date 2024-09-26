namespace cSharp;

class MyQueue
{

    // Create a Queue that stores strings
    // Add three strings in queue
    // Write a method that removes the first string in the queue and writes it to the console
    // Add two more strings and repeate remove until the queue is empty
    // Use the methods Enqueu and Dequeue

    private Queue<string> _queue;

    public MyQueue()
    {
        _queue = new Queue<string>();
    }

    public void modifyQueue()
    {
        Console.WriteLine("Original Queue: ");

        _queue.Enqueue("Spoon");
        _queue.Enqueue("Fork");
        _queue.Enqueue("Knife");

        foreach (var item in _queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(_queue.Dequeue());

        Console.WriteLine("\nDequeued Queue: ");

        while (_queue.Count > 0)
        {
            var dequeueItem = _queue.Dequeue();
            Console.WriteLine(dequeueItem);
        }

        Console.WriteLine("\nUpdated Queue: ");

        _queue.Enqueue("Plate");
        _queue.Enqueue("Cup");

        foreach (var item in _queue)
        {
            Console.WriteLine(item);
        }
    }
}
