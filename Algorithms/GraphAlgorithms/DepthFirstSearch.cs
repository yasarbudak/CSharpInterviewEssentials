using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms
{
  /// <summary>
  /// Genellikle bir yığın veya özyinelemeli (recursive) bir yapı kullanılarak uygulanır. 
  /// Bir yolda mümkün olduğu kadar derine gider, sonra geri dönüp diğer dalları keşfeder.
  /// 
  /// Çalışma Prensibi: Başlangıç düğümünden başlar, bir yolda mümkün olduğu kadar derine gider. Eğer tüm komşular ziyaret edilmişse, geri dönerek diğer dallara geçer.
  /// Zaman Karmaşıklığı: O(V + E), burada V düğüm sayısı ve E kenar sayısıdır.
  /// Kullanım Alanları: Döngü tespiti, yol bulma ve ağ topolojisi analizi gibi problemlerde kullanılır.
  /// Avantajları: Daha derin dalları keşfetmek için etkilidir.
  /// Dezavantajları: Döngü içeren graf yapılarında sonsuz döngüye girme riski vardır (bu yüzden ziyaret edilen düğümler takip edilir).
  /// </summary>
  public class DepthFirstSearch
  {
    public static void Traverse(Dictionary<int, List<int>> graph, int start)
    {
      var visited = new HashSet<int>();
      DFS(graph, start, visited);
    }

    private static void DFS(Dictionary<int, List<int>> graph, int node, HashSet<int> visited)
    {
      visited.Add(node);
      Console.WriteLine("Visited node: " + node);

      if (!graph.ContainsKey(node)) return;

      foreach (var neighbor in graph[node])
      {
        if (!visited.Contains(neighbor))
        {
          DFS(graph, neighbor, visited);
        }
      }
    }
  }
}
