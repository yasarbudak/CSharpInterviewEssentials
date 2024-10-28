using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BasicSorting
{
  /// <summary>
  /// Bubble Sort, en basit sıralama algoritmalarından biridir. Karşılaştırmaya dayalı olarak çalışır ve her geçişte en büyük elemanı dizinin sonuna taşır.
  /// Diziyi baştan sona dolaşır, bitişik elemanları karşılaştırır.
  /// Eğer bir eleman kendinden sonraki elemandan büyükse, yer değiştirir.
  /// Bu işlem dizideki tüm elemanlar sıralanıncaya kadar devam eder.
  /// 
  /// Zaman Karmaşıklığı: En kötü ve ortalama durumda O(n²)
  /// Bubble Sort, ek bellek kullanmaz ve dizi üzerinde doğrudan işlem yapar.
  /// Basit olması nedeniyle eğitim amaçlı ve küçük veri kümelerinde tercih edilir.
  /// Diğer sıralama algoritmalarına göre verimsizdir ve büyük veri kümeleri için uygun değildir.
  /// </summary>
  public class BubbleSort
  {
    public static void Sort(int[] array)
    {
      for (int i = 0; i < array.Length - 1; i++)
      {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
          if (array[j] > array[j + 1])
          {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
          }
        }
      }
      Console.WriteLine("Bubble Sorted Array: " + string.Join(", ", array));
    }
  }
}
