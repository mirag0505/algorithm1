using System.Collections;

namespace RotateQueue;

public class RotateQueue
{
    public static void RotateQueueFn(int countToRotate, System.Collections.Generic.Queue<object> queue)
    {
        for (int item = 0; item < countToRotate; item++)
        {
            if (queue.Count > 1)
            {
                var first = queue.Dequeue();
                queue.Enqueue(first);
            }
        }
    }
}
