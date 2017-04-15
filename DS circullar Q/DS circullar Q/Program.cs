using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_circullar_Q
{
    public struct CircularQueue
    {
        public int Front;
        public int Rear;
        public int[] items;
    }

    public class CircularQueueStructure
    {
        CircularQueue queue = new CircularQueue();
        public CircularQueueStructure(int value)
        {
            queue.items = new int[value];
        }

        public void Demo()
        {
            queue.Front = -1;
            queue.Rear = -1;
            var items = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= queue.items.Length; i++)
            {
                Console.Write("Enter the " + i.ToString() + " Value :");
                Insert(i);
            }

            Display();
            Delete();
            Insert(4);
            Display();
            Insert(4);
            Delete();
            Delete();
            Insert(4);
            Display();
            Insert(5);
            Display();
            Insert(1);
            Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("The items are");
            {
                for (int i = 0; i < queue.items.Length; i++)
                {
                    Console.WriteLine(queue.items[i]);
                }
            }
        }

        public int Delete()
        {
            queue.Front++;
            return -1;
        }

        public void Insert(int value)
        {
            if (((queue.Rear + 1) % 5) == queue.Front)
                Console.WriteLine("queue is full");
            else
            {
                queue.Rear++;
                queue.Rear = (queue.Rear) % 5;
                queue.items[queue.Rear] = value;
            }
            if (queue.Front == -1)
                queue.Front = 0;
        }
    }
}