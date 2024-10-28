using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TreesAndGraphs
{
  public class TreeNode
  {
    public int Data { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int data)
    {
      Data = data;
      Left = null;
      Right = null;
    }
  }
}
