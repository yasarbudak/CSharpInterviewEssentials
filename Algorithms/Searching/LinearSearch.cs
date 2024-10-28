using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
  /// <summary>
  /// En basit arama algoritmasıdır. Diziyi baştan sona dolaşarak istenen elemanı bulmaya çalışır.
  /// 
  /// Çalışma Prensibi: Dizi baştan sona taranır ve her eleman hedef elemanla karşılaştırılır. Hedef eleman bulunursa arama tamamlanır, bulunamazsa dizi sonuna kadar taranır.
  /// Zaman Karmaşıklığı: En kötü durumda ve ortalama durumda O(n).
  /// Avantajları: Basit bir algoritma olup sıralı bir dizi gerektirmez.
  /// Dezavantajları: Büyük veri kümelerinde verimli değildir, çünkü her elemanı kontrol eder.
  /// </summary>
  public class LinearSearch
  {
    public static int Search(int[] array, int target)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == target)
        {
          Console.WriteLine($"Element {target} found at index {i} using Linear Search.");
          return i;
        }
      }
      Console.WriteLine($"Element {target} not found in the array.");
      return -1;
    }
  }
}
