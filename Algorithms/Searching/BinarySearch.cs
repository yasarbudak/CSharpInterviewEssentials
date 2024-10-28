using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
  /// <summary>
  /// Sıralı bir dizide belirli bir değeri aramak için kullanılan etkili bir algoritmadır. 
  /// 
  /// Çalışma Prensibi: Sıralı bir dizide çalışır. Dizinin ortasındaki elemanı kontrol eder. Eğer hedef eleman ortadaki elemandan küçükse sol yarıda, büyükse sağ yarıda arama yapılır. Bu işlem hedef eleman bulunana kadar veya dizi bölünemeyecek kadar küçük hale gelene kadar devam eder.
  /// Zaman Karmaşıklığı: O(log n), çünkü her adımda arama alanını yarıya indirir.
  /// Avantajları: Sıralı dizilerde çok verimlidir ve büyük veri kümeleri için uygundur.
  /// Dezavantajları: Dizi sıralı değilse çalışmaz.
  /// </summary>
  public class BinarySearch
  {
    public static int Search(int[] array, int target)
    {
      int left = 0;
      int right = array.Length - 1;

      while (left <= right)
      {
        int mid = left + (right - left) / 2;

        if (array[mid] == target)
        {
          Console.WriteLine($"Element {target} found at index {mid} using Binary Search.");
          return mid;
        }

        if (array[mid] < target)
        {
          left = mid + 1;
        }
        else
        {
          right = mid - 1;
        }
      }

      Console.WriteLine($"Element {target} not found in the array.");
      return -1;
    }
  }
}
