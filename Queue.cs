using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Queues
{
    class Queue
    {
        const int MaxSize = 4;
        private string[] QUEUE = new string[MaxSize];
        private int Size = 4;
        private int front = 0;
        private int rear = -1;



        public Queue()
        {
        }

        public bool IsFull()
        {
            if (rear + 1 == MaxSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public int Enqueue(string Data) //Adds a value to the end of the queue
        {
            if (IsFull() == true)
            {
                Console.WriteLine($"\nQueue is full - {Data} not added");
            }
            else
            {
                rear = rear + 1;
                QUEUE[rear] = Data;
            }

            return rear;
        }

        public void PrintQueue() //Prints the queue from beginning to end
        {
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(QUEUE[i]);
            }
        }


    }
}