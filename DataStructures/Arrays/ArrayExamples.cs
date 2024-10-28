using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
  /// <summary>
  /// Bu sınıf diziler ile ilgili temel işlemleri sunar. Ayrıca, temel veri yapılarından olan dizilerin kısa bir tanımını da bulabilirsiniz.
  /// 
  /// Diziler, aynı türdeki verileri ardışık bellek alanlarında saklayan, sabit boyutlu yapılardır.
  /// Dizi elemanlarına indeks yolu ile doğrudan erişim sağlanır. 
  /// Bu yapı, elemanlara O(1) zaman karmaşıklığında erişim sağlar.
  /// Bellekte ardışık olarak yerleştirildikleri için hızlıdırlar
  /// Sabit boyutlu oldukları için dinamik genişleme zordur, eleman ekleme veya silme yüksek maliyetlidir.
  /// </summary>
  public class ArrayExamples
  {
    //Run all array examples
    public static void Run()
    {
      BasicArrayOperations();
      LinearSearchExample();
      ReverseArrayExample();
    }

    //Basic operations on an array
    private static void BasicArrayOperations()
    {
      int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };
      Console.WriteLine("Original Array:");
      Console.WriteLine(string.Join(", ", numbers));

      //Accessing elements by index
      Console.WriteLine($"First element: {numbers[0]}");
      Console.WriteLine($"Second element: {numbers[1]}");
      Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");

      //Array length
      Console.WriteLine($"Array Length: {numbers.Length}");
    }

    // Linear search in an array
    private static void LinearSearchExample()
    {
      int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
      int target = 15;
      int index = LinearSearch(numbers, target);
      Console.WriteLine(index != -1 ? $"Element {target} found at index {index}" : "Element not found");
    }

    // Reverse the elements of an array
    private static int LinearSearch(int[] numbers, int target)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] == target)
          return i;

      }
      return -1;
    }

    private static void ReverseArrayExample()
    {
      int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
      ReverseArray(numbers);
      Console.WriteLine("Reversed array: " + string.Join(", ", numbers));
    }

    private static void ReverseArray(int[] numbers)
    {
      int start = 0;
      int end = numbers.Length - 1;

      while (start < end)
      {
        int temp = numbers[start];
        numbers[start] = numbers[end];
        numbers[end] = temp;
        start++;
        end--;
      }
    }
  }
}
