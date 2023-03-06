using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_And_HashTable;

public class Node
{
    public int item;
    public Node leftCount;
    public Node rightCount;
    public int data;
    public Node(int data)
    {
        item = data;
        leftCount = null;
        rightCount = null;
    }
}
