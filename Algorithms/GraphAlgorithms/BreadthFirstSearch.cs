using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms
{
  /// <summary>
  /// Genellikle bir kuyruk veri yapısı kullanılarak uygulanır. En yakın komşulardan başlayarak genişleyerek tüm düğümleri dolaşır.
  /// 
  /// Çalışma Prensibi: Başlangıç düğümünden başlar, önce düğümün tüm komşularını keşfeder, sonra bir sonraki seviyeye geçer.
  /// Zaman Karmaşıklığı: O(V + E), burada V düğüm sayısı ve E kenar sayısıdır.
  /// Kullanım Alanları: Kısa yol bulma, ağ bağlantısı analizi gibi problemlerde kullanılır.
  /// Avantajları: Belirli bir düğüme olan en kısa yolu bulmada etkilidir.
  /// Dezavantajları: Daha derin bir graf yapısında daha fazla bellek kullanabilir.
  /// </summary>
  public class BreadthFirstSearch
  {
    public static void Traverse(Dictionary<int, List<int>> graph, int start)
    {
      var visited = new HashSet<int>();
      var queue = new Queue<int>();
      queue.Enqueue(start);
      visited.Add(start);

      while (queue.Count > 0)
      {
        int node = queue.Dequeue();
        Console.WriteLine("Visited node: " + node);

        if (!graph.ContainsKey(node)) continue;

        foreach (var neighbor in graph[node])
        {
          if (!visited.Contains(neighbor))
          {
            queue.Enqueue(neighbor);
            visited.Add(neighbor);
          }
        }
      }
    }
  }
}
