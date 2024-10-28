using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StacksAndQueues
{
  /// <summary>
  /// LIFO (Last In, First Out) prensibiyle çalışan bir veri yapısıdır. Yığına en son eklenen eleman ilk çıkar. 
  /// İki temel işleme sahiptir. Bunlar, Push ve Pop'tur. Push yığına eleman ekler, Pop en üstteki elemanı çıkarır.
  /// Fonksiyon çağrılarının izlenmesi, tarayıcı ileri/geri işlemleri, undo/redo işlemleri kullanım alanlarıdır.
  /// 
  /// Veri ekleme ve çıkarma işlemlerinde O(1) zaman karmaşıklığına sahiptir.
  /// Yalnızca en üstteki elemana erişilir, araya erişim veya ekleme desteklenmez.
  /// </summary>
  public class StackExamples
  {
    private int[] stackArray;
    private int top;
    private int maxSize;

    // Constructor to initialize stack
    public StackExamples(int size)
    {
      maxSize = size;
      stackArray = new int[maxSize];
      top = -1;
    }

    // Push: Add an element to the top of the stack
    public void Push(int value)
    {
      if (top == maxSize - 1)
      {
        Console.WriteLine("Stack overflow! Cannot add more elements.");
        return;
      }
      stackArray[++top] = value;
    }

    // Pop: Remove and return the top element of the stack
    public int Pop()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Stack underflow! No elements to pop.");
        return -1;
      }
      return stackArray[top--];
    }

    // Peek: Return the top element without removing it
    public int Peek()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Stack is empty.");
      }
      return stackArray[top];
    }

    // IsEmpty: Check if the stack is empty
    public bool IsEmpty()
    {
      return top == -1;
    }

    // Display: Show all elements in the stack
    public void Display()
    {
      if (!IsEmpty())
      {
        Console.WriteLine("Stack is empty.");
      }

      Console.WriteLine("Stack elements:");
      for (int i = top; i >= 0; i--)
      {
        Console.WriteLine(stackArray[i]);
      }
    }
  }
}
