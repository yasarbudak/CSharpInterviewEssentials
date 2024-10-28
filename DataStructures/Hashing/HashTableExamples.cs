using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Hashing
{
  /// <summary>
  /// Hash Table, veriler key-value çiftleri olarak saklayan bir veri yapısıdır.
  /// Her anahtar, bir hash fonksiyonu aracılığı ile bir dizi indeksine dönüştürülür ve bu indeks üzerinden tabloya yerleştirilir.
  /// 
  /// Veriye hızlı erişim sağlar ve genellikle O(1) zaman karmaşıklığına sahiptir.
  /// 
  /// Veri tabanları, cache sistemleri ve anahtar-değer eşleme gerektiren işlemlerde kullanılır.
  /// </summary>
  public class HashTableExamples
  {
    private readonly int _size;
    private readonly string[]? _table;

    // Constructor to initialize hash table with a specific size
    public HashTableExamples(int size)
    {
      this._size = size;
      _table = new string[size];
    }

    // Hash function to calculate index for a given key
    private int HashFunction(string key)
    {
      int hash = 0;
      foreach (char c in key)
      {
        hash += c;
      }
      return hash % _size;
    }

    // Add a key-value pair to the hash table
    public void Add(string key, string value)
    {
      int index = HashFunction(key);

      if (_table[index] == null)
      {
        _table[index] = value;
        Console.WriteLine($"Added ({key}: {value}) at index {index}");
      }
      else
      {
        Console.WriteLine($"Collision occurred at index {index} for key {key}. Value not added.");
      }
    }

    // Find a value by key in the hash table
    public string Find(string key)
    {
      int index = HashFunction(key);

      if (_table[index] != null)
      {
        return _table[index];
      }
      else
      {
        Console.WriteLine($"No value found for key {key}");
        return null;
      }
    }

    // Remove a key-value pair from the hash table
    public void Remove(string key)
    {
      int index = HashFunction(key);

      if (_table[index] != null)
      {
        Console.WriteLine($"Removed ({key}: {_table[index]}) from index {index}");
        _table[index] = null;
      }
      else
      {
        Console.WriteLine($"No value found at index {index} for key {key}");
      }
    }

    // Display all elements in the hash table
    public void Display()
    {
      Console.WriteLine("Hash Table Contents:");
      for (int i = 0; i < _size; i++)
      {
        if (_table[i] != null)
        {
          Console.WriteLine($"Index {i}: {_table[i]}");
        }
      }
    }
  }
}
