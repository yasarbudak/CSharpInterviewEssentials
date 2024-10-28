using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BasicSorting
{
  /// <summary>
  /// Insertion Sort, her adımda bir eleman seçip sıralı bir alt diziye yerleştirerek sıralama yapar.
  /// 
  /// İlk elemanı sıralı kabul eder, diğer elemanları birer birer bu sıralı kısmın içine yerleştirir.
  /// Her yeni eleman, kendisinden büyük olan elemanların önüne yerleştirilir.
  /// Bu işlem dizinin sonuna kadar devam eder.
  ///
  /// Zaman Karmaşıklığı: En kötü durumda O(n²), en iyi durumda O(n) (örneğin, dizi zaten sıralıysa).
  /// Bellek Kullanımı: Ekstra bellek kullanımı yoktur.
  /// Kullanım Alanları: Küçük veri kümelerinde ve kısmen sıralı dizilerde tercih edilir.
  /// Avantajları: Küçük ve kısmen sıralı dizilerde hızlıdır.
  /// </summary>
  public class InsertionSort
  {
    public static void Sort(int[] array)
    {
      for (int i = 1; i < array.Length; i++)
      {
        int key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > key)
        {
          array[j + 1] = array[j];
          j--;
        }
        array[j + 1] = key;
      }
      Console.WriteLine("Insertion Sorted Array: " + string.Join(", ", array));
    }
  }
}
