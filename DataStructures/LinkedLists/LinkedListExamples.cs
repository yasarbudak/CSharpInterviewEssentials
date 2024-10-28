using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
  /// <summary>
  /// Bellekte ardışık olmayan ve her düğümde bir sonraki düğüme işaret eden bir bağlantı içeren dinamik veri yapısıdır.
  /// 
  /// Diziler ile arasındaki farklar, dinamik boyutlu olmaları ve bellek alanlarında dağınık bir şekilde saklanabilmeleridir.
  /// 
  /// Dinamik boyutlu olmaları, kolayca eleman eklenip çıkarılması avantajlarıdır.
  /// Elemanlarına doğrudan erişim sağlanamaması, her eleman için O(n) arama süresi gerekmesi dezavantajlarıdır.
  /// </summary>
  public class LinkedListExamples
  {
    private Node head;
    public LinkedListExamples()
    {
      head = null;
    }

    // Add a new node at the end of the list
    public void AddLast(int data)
    {
      Node newNode = new Node(data);
      if (head == null)
      {
        head = newNode;
        return;
      }

      Node current = head;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = newNode;
    }

    // Add a new node at the beginning of the list
    public void AddFirst(int data)
    {
      Node newNode = new Node(data);
      newNode.Next = head;
      head = newNode;
    }

    // Remove the first node with the specified data
    public void Remove(int data)
    {
      if (head == null) { return; }

      if (head.Data == data)
      {
        head = head.Next;
        return;
      }

      Node current = head;
      while (current.Next != null)
      {
        current = current.Next;
      }

      if (current.Next != null)
      {
        current.Next = current.Next.Next;
      }
    }

    // Display all nodes in the list
    public void Display()
    {
      Node current = head;
      while (current != null)
      {
        Console.WriteLine(current.Data + " -> ");
        current = current.Next;
      }
      Console.WriteLine("null");
    }
  }
}
