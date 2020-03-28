using System;
using System.Collections.Generic;

namespace GenericQueue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue<string> queueList = new Queue<string>();

            queueList.Enqueue("AAA");
            queueList.Enqueue("BBB");
            queueList.Enqueue("CCC");

            Console.WriteLine("At the top " + queueList.Peek());
            
            foreach (var item in queueList)
            {
                Console.WriteLine(item);
            }

            queueList.Dequeue();
            queueList.Dequeue();

            Console.WriteLine("At the top " + queueList.Peek());
           
            foreach (var item in queueList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
