using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.AdvancedSorting
{
  /// <summary>
  /// Heap Sort bir sıralama algoritmasıdır ve Heap Veri Yapısı kullanır. 
  /// Bu algoritma özellikle Min-Heap veya Max-Heap adı verilen ikili ağaç yapılarından yararlanır. 
  /// Heap Sort genellikle O(n log n) zaman karmaşıklığına sahiptir ve sıralama yapılırken ekstra bir belleğe ihtiyaç duymaz.
  /// 
  /// Öncelik sırası gerektiren durumlarda (priority queue), sayısal veri sıralama işlemlerinde kullanılır.
  /// Bellek açısından verimlidir ve istikrarlı bir performansa sahiptir.
  /// Diğer sıralama algoritmalarına kıyasla karmaşık bir yapıya sahiptir ve ek maliyet gerektirir.
  /// </summary>
  /// <param name="array"></param>
  public class HeapSort
  {
    public static void Sort(int[] array)
    {
      int n = array.Length;

      for (int i = n / 2 - 1; i >= 0; i--)
        Heapify(array, n, i);

      for (int i = n - 1; i >= 0; i--)
      {
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;

        Heapify(array, i, 0);
      }
      Console.WriteLine("Heap Sorted Array: " + string.Join(", ", array));
    }

    private static void Heapify(int[] array, int n, int i)
    {
      int largest = i;
      int left = 2 * i + 1;
      int right = 2 * i + 2;

      if (left < n && array[left] > array[largest])
        largest = left;

      if (right < n && array[right] > array[largest])
        largest = right;

      if (largest != i)
      {
        int swap = array[i];
        array[i] = array[largest];
        array[largest] = swap;

        Heapify(array, n, largest);
      }
    }
  }
}
