using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TreesAndGraphs
{
  /// <summary>
  /// Binary Search Tree node’lardan oluşan ve her bir node’un en fazla 2 child node’a sahip olduğu veri yapılarından bir tanesidir.
  /// Node, bir veri yapısının en temel birimidir. Node’lar veriler içerebilirler ve aynı zamanda diğer nodelar ile aralarında bir bağlantı bulundurabilirler.
  /// Binary Search Treede en üstte bulunan node Root olarak adlandırılır.
  /// Root’tan küçük değere sahip olan node’lar Root’un sol tarafında yer alır
  /// Root’tan büyük değere sahip olan node’lar Root’un sağ tarafında yer alır.
  /// Bu kural Recursive olarak sol ve sağ tarafta yer alan subtree’ler içinde geçerlidir.
  /// </summary>
  public class BinaryTreeExamples
  {
    private TreeNode? _root;
    public BinaryTreeExamples()
    {
      _root = null;
    }

    // Add: Add a new node to the binary tree
    public void Add(int value)
    {
      _root = AddRecursive(_root, value);
    }

    private TreeNode? AddRecursive(TreeNode? node, int value)
    {
      if (node == null)
      {
        return new TreeNode(value);
      }

      if (value < node.Data)
      {
        node.Left = AddRecursive(node.Left, value);
      }
      else if (value > node.Data)
      {
        node.Right = AddRecursive(node.Right, value);
      }
      return node;
    }

    // Find: Search for a node in the binary tree
    public bool Find(int value)
    {
      return FindRecursive(_root, value);
    }

    private bool FindRecursive(TreeNode? node, int value)
    {
      if (node == null)
      {
        return false;
      }

      if (value == node.Data)
      {
        return true;
      }
      else if (value < node.Data)
      {
        return FindRecursive(node.Left, value);
      }
      else
      {
        return FindRecursive(node.Right, value);
      }
    }

    // In-Order Traversal: Traverse the binary tree in in-order
    public void InOrderTraversal()
    {
      InOrderRecursive(_root);
      Console.WriteLine();
    }

    private void InOrderRecursive(TreeNode? node)
    {
      if (node != null)
      {
        InOrderRecursive(node.Left);
        Console.WriteLine(node.Data + " ");
        InOrderRecursive(node.Right);
      }
    }
  }
}
