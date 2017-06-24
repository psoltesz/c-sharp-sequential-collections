using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            queue.Enqueue("fourth");
            queue.Enqueue("fifth");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();

                Console.WriteLine("From Queue: {0}", obj);
            }

            Console.ReadKey();

            Console.WriteLine();

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("Fifth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }

            Console.ReadKey();
        }
    }
}
