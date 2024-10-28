using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StacksAndQueues
{
  /// <summary>
  /// FIFO (First In, Last Out) prensibiyle çalışan bir veri yapısıdır. Kuyruğa ilk giren eleman ilk çıkar. 
  /// İki temel işleme sahiptir. Bunlar, Enqueue ve Dequeue'dir. Enqueue yığına eleman ekler, Dequeue kuyruktan eleman çıkarır.
  /// 
  /// Baskı sıraları, işlem sıraları, veri akışı gibi sıralı işlemlerde kullanılır.
  /// 
  /// Veri ekleme ve çıkarma işlemlerinde O(1) zaman karmaşıklığına sahiptir.
  /// Sadece baştaki ve sondaki elemanlara erişilebilir, araya erişim veya ekleme desteklenmez.
  /// </summary>
  public class QueueExamples
  {
    private int[] queueArray;
    private int front;
    private int rear;
    private int maxSize;
    private int currentSize;

    public QueueExamples(int size)
    {
      maxSize = size;
      queueArray = new int[maxSize];
      front = 0;
      rear = -1;
      currentSize = 0;
    }

    // Enqueue: Add an element to the rear of the queue
    public void Enqueue(int value)
    {
      if (currentSize == maxSize)
      {
        Console.WriteLine("Queue overflow! Cannot add more elements.");
        return;
      }

      rear = (rear + 1) % maxSize;
      queueArray[rear] = value;
      currentSize++;
    }

    // Dequeue: Remove and return the front element of the queue
    public int Dequeue()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Queue underflow! No elements to dequeue.");
        return -1;
      }

      int value = queueArray[front];
      front = (front + 1) % maxSize;
      currentSize--;
      return value;
    }

    // Peek: Return the front element without removing it
    public int Peek() 
    {
      if (IsEmpty()) 
      {
        Console.WriteLine("Queue is empty.");
        return -1;
      }

      return queueArray[front];
    }

    // IsEmpty: Check if the queue is empty
    public bool IsEmpty()
    {
      return currentSize == 0;
    }

    // Display: Show all elements in the queue
    public void Display()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Queue is empty.");
        return;
      }

      Console.WriteLine("Queue elements:");
      int count = currentSize;
      int index = front;
      while (count > 0)
      {
        Console.WriteLine(queueArray[index]);
        index = (index + 1) % maxSize;
        count--;
      }
    }
  }
}
