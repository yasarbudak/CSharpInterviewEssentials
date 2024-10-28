using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.AdvancedSorting
{
  public class MergeSort
  {
    /// <summary>
    /// Merge Sort, “böl ve fethet” (divide and conquer) prensibiyle çalışan bir sıralama algoritmasıdır.
    /// Dizi ikiye bölünerek her iki yarıda ayrı ayrı sıralama yapılır.
    /// Her bölünen parça kendi içinde sıralandıktan sonra iki sıralı yarı birleştirilir.
    /// Bu işlem dizi tamamen sıralanana kadar devam eder.
    ///
    /// Zaman Karmaşıklığı: Her durumda O(n log n).
    /// Bellek Kullanımı: Ekstra bellek kullanır çünkü diziyi yeniden birleştirirken geçici dizi alanı kullanır.
    /// Kullanım Alanları: Büyük veri kümelerinde ve stabil sıralama gerektiğinde tercih edilir.
    /// Avantajları: Zaman karmaşıklığı her durumda O(n log n) olup, verimlidir.
    /// Dezavantajları: Ekstra bellek kullanımı gerektirir.
    /// </summary>
    /// <param name="array"></param>
    public static void Sort(int[] array)
    {
      if (array.Length <= 1) return;

      int mid = array.Length / 2;
      int[] left = new int[mid];
      int[] right = new int[array.Length - mid];

      Array.Copy(array, 0, left, 0, mid);
      Array.Copy(array, mid, right, 0, array.Length - mid);

      Sort(left);
      Sort(right);

      Merge(array, left, right);
      Console.WriteLine("Merge Sorted Array: " + string.Join(", ", array));
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
      int i = 0, j = 0, k = 0;
      while (i < left.Length && j < right.Length)
      {
        if (left[i] <= right[j])
        {
          array[k++] = left[i++];
        }
        else
        {
          array[k++] = right[j++];
        }
      }
      while (i < left.Length) array[k++] = left[i++];
      while (j < right.Length) array[k++] = right[j++];
    }
  }
}
