using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BasicSorting
{
  /// <summary>
  /// Selection Sort, her geçişte dizinin en küçük elemanını bularak dizinin başına koyar.
  /// Dizinin en küçük elemanını bulur ve dizinin başındaki elemanla yer değiştirir.
  /// Ardından, sıralanmamış kalan kısmın en küçük elemanını bulup dizinin başına koyma işlemini tekrar eder.
  /// Tüm elemanlar sıralanana kadar bu işlem devam eder.
  /// 
  /// Zaman Karmaşıklığı: En kötü ve ortalama durumda O(n²).
  /// Bellek Kullanımı: Ekstra bellek kullanımı yoktur.
  /// Kullanım Alanları: Basit olması nedeniyle küçük veri kümelerinde tercih edilir.
  /// Dezavantajları: Karşılaştırma sayısı fazladır, büyük veri kümeleri için uygun değildir.
  /// </summary>
  public class SelectionSort
  {
    public static void Sort(int[] array)
    {
      for (int i = 0; i < array.Length - 1; i++)
      {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
          if (array[j] < array[minIndex])
          {
            minIndex = j;
          }
        }
        int temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
      }
      Console.WriteLine("Selection Sorted Array: " + string.Join(", ", array));
    }
  }
}