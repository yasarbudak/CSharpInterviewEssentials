using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TreesAndGraphs
{
  /// <summary>
  /// Graph, düğümler (vertices) ve bu düğümleri birbirine bağlayan kenarlardan (edge) oluşan bir veri yapısıdır.
  /// Directed Graph (Yönlü Graf) ve Undirected Graph (Yönsüz Graf) olmak üzere iki temel türü vardır.
  /// 
  /// Yol bulma, sosyal ağ analizleri, ağ topolojisi, veri yapısı temelli algoritmalarda kullanılır.
  /// Karmaşık ilişki ağlarını modellemek için uygundur.
  /// Bellek kullanımı yüksektir, özellikle tüm düğüm ve kenarlar saklandığında.
  /// </summary>
  public class GraphExamples
  {
    private readonly Dictionary<int, List<int>> adjacencyList;

    public GraphExamples()
    {
      adjacencyList = new Dictionary<int, List<int>>();
    }

    // AddVertex: Adds a vertex to the graph
    public void AddVertex(int vertex)
    {
      if (!adjacencyList.ContainsKey(vertex))
      {
        adjacencyList[vertex] = new List<int>();
        Console.WriteLine($"Vertex {vertex} added.");
      }
      else 
      {
        Console.WriteLine($"Vertex {vertex} already exists.");
      }
    }

    // AddEdge: Adds an edge between two vertices (directed)
    public void AddEdge(int startVertex, int endVertex)
    {
      if (adjacencyList.ContainsKey(startVertex) && adjacencyList.ContainsKey(endVertex))
      {
        adjacencyList[startVertex].Add(endVertex);
        Console.WriteLine($"Edge from {startVertex} to {endVertex} added.");
      }
      else
      {
        Console.WriteLine($"One or both vertices not found: {startVertex}, {endVertex}");
      }
    }

    // DisplayGraph: Displays the adjacency list of the graph
    public void DisplayGraph()
    {
      Console.WriteLine("Graph adjacency list:");
      foreach (var vertex in adjacencyList)
      {
        Console.Write($"{vertex.Key}: ");
        foreach (var edge in vertex.Value)
        {
          Console.Write($"{edge} ");
        }
        Console.WriteLine();
      }
    }
  }
}
