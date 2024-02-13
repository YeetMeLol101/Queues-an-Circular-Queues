using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Queues
{
    class CQueue
    {
        const int MaxSize = 4;
        private string[] QUEUE = new string[MaxSize];
        private int Size = 4;
        private int front = -1;
        private int rear = -1;



        public CQueue()
        {
        }

        public bool IsFull()
        {
            if ((rear + 1) % MaxSize == front)
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
                rear = (rear + 1) % MaxSize;
                QUEUE[rear] = Data;
                if (front == -1) //First item to be queued
                    front = 0;
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