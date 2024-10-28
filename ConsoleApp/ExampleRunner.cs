using Algorithms.GraphAlgorithms;
using Algorithms.Searching;
using Algorithms.Sorting.AdvancedSorting;
using Algorithms.Sorting.BasicSorting;
using DataStructures.Arrays;
using DataStructures.Hashing;
using DataStructures.LinkedLists;
using DataStructures.StacksAndQueues;
using DataStructures.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  public class ExampleRunner
  {
    public static void Run()
    {
      while (true)
      {
        Console.WriteLine("Choose an example to run:");
        Console.WriteLine("1. Array Examples");
        Console.WriteLine("2. Linked List Examples");
        Console.WriteLine("3. Stack Examples");
        Console.WriteLine("4. Queue Examples");
        Console.WriteLine("5. Binary Tree Examples");
        Console.WriteLine("6. Hash Table Examples");
        Console.WriteLine("7. Graph Examples");
        Console.WriteLine("8. Sorting Examples");
        Console.WriteLine("9. Searching Examples");
        Console.WriteLine("10. Graph Examples");
        Console.WriteLine("0. Exit");

        var choice = Console.ReadLine();
        switch (choice)
        {
          case "1":
            Console.WriteLine("\nRunning Array Examples:");
            ArrayExamples.Run();
            break;
          case "2":
            Console.WriteLine("\nRunning Linked List Examples:");
            LinkedListExamples list = new LinkedListExamples();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(5);
            Console.WriteLine("List after adding elements:");
            list.Display();
            list.Remove(20);
            Console.WriteLine("List after removing 20:");
            list.Display();
            break;
          case "3":
            Console.WriteLine("\nRunning Stack Examples:");
            StackExamples stack = new StackExamples(5);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Current top element (Peek): " + stack.Peek());
            stack.Display();
            Console.WriteLine("Popped element: " + stack.Pop());
            Console.WriteLine("Current top element (Peek): " + stack.Peek());
            stack.Display();
            break;
          case "4":
            Console.WriteLine("\nRunning Queue Examples:");
            QueueExamples queue = new QueueExamples(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine("Current front element (Peek): " + queue.Peek());
            queue.Display();
            Console.WriteLine("Dequeued element: " + queue.Dequeue());
            Console.WriteLine("Current front element (Peek): " + queue.Peek());
            queue.Display();
            break;
          case "5":
            Console.WriteLine("\nRunning Binary Tree Examples:");
            BinaryTreeExamples tree = new BinaryTreeExamples();
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);
            Console.WriteLine("In-Order Traversal:");
            tree.InOrderTraversal();
            Console.WriteLine("Finding 40: " + (tree.Find(40) ? "Found" : "Not found"));
            Console.WriteLine("Finding 100: " + (tree.Find(100) ? "Found" : "Not found"));
            break;
          case "6":
            Console.WriteLine("\nRunning Hash Table Examples:");
            HashTableExamples hashTable = new HashTableExamples(10);
            hashTable.Add("name", "Alice");
            hashTable.Add("age", "30");
            hashTable.Add("city", "Istanbul");
            Console.WriteLine("Finding 'name': " + hashTable.Find("name"));
            hashTable.Remove("age");
            hashTable.Display();
            break;
          case "7":
            Console.WriteLine("\nRunning Graph Examples:");
            GraphExamples graph = new GraphExamples();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 1);
            graph.DisplayGraph();
            break;
          case "8":
            int[] array = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Original Array: " + string.Join(", ", array));

            BubbleSort.Sort((int[])array.Clone());
            SelectionSort.Sort((int[])array.Clone());
            InsertionSort.Sort((int[])array.Clone());
            MergeSort.Sort((int[])array.Clone());
            QuickSort.Sort((int[])array.Clone(), 0, array.Length - 1);
            HeapSort.Sort((int[])array.Clone());
            break;
          case "9":
            int[] searchArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            Console.WriteLine("Original Array: " + string.Join(", ", searchArray));

            LinearSearch.Search(searchArray, 10);
            LinearSearch.Search(searchArray, 3);

            BinarySearch.Search(searchArray, 14);
            BinarySearch.Search(searchArray, 5);
            break;
          case "10":
            var grp = new Dictionary<int, List<int>>
            {
              { 1, new List<int> { 2, 3 } },
              { 2, new List<int> { 4 } },
              { 3, new List<int> { 5 } },
              { 4, new List<int> { 6 } },
              { 5, new List<int> { 6 } },
              { 6, new List<int>() }
            };
            Console.WriteLine("Running Breadth-First Search:");
            BreadthFirstSearch.Traverse(grp, 1);
            Console.WriteLine("\nRunning Depth-First Search:");
            DepthFirstSearch.Traverse(grp, 1);
            break;
          case "0":
            Console.WriteLine("Exiting...");
            return;
          default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
      }
    }
  }
}
