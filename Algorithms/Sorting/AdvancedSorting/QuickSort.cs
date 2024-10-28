using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.AdvancedSorting
{
  public class QuickSort
  {
    /// <summary>
    /// Quick Sort da “böl ve fethet” prensibine dayanır, ancak pivot kullanarak çalışır.
    /// Bir pivot eleman seçilir, dizinin küçük elemanları sola, büyük elemanları sağa yerleştirilir.
    /// Bu işlemi dizinin her iki alt yarısında tekrar eder.
    /// Sonunda tüm elemanlar sıralanmış olur.
    ///
    /// Zaman Karmaşıklığı: En kötü durumda O(n²), ortalama durumda O(n log n).
    /// Bellek Kullanımı: Ekstra bellek gerektirmez.
    /// Kullanım Alanları: Büyük veri kümelerinde tercih edilir.
    /// Avantajları: Ortalama durumda çok verimlidir ve ek bellek gerektirmez.
    /// Dezavantajları: En kötü durumda O(n²) olabilir(örneğin, dizi sıralıysa ve pivot doğru seçilmezse).
    /// </summary>
    /// <param name="array"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    public static void Sort(int[] array, int low, int high)
    {
      if (low < high)
      {
        int pi = Partition(array, low, high);
        Sort(array, low, pi - 1);
        Sort(array, pi + 1, high);
      }
      Console.WriteLine("Quick Sorted Array: " + string.Join(", ", array));
    }

    private static int Partition(int[] array, int low, int high)
    {
      int pivot = array[high];
      int i = (low - 1);

      for (int j = low; j < high; j++)
      {
        if (array[j] < pivot)
        {
          i++;
          int temp = array[i];
          array[i] = array[j];
          array[j] = temp;
        }
      }
      int temp1 = array[i + 1];
      array[i + 1] = array[high];
      array[high] = temp1;

      return i + 1;
    }
  }
}
