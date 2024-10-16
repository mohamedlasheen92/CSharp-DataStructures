using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
  internal class LinkedListIterator
  {
    private LinkedListNode CurrentNode;

    public LinkedListIterator()
    {
      CurrentNode = null;
    }
    public LinkedListIterator(LinkedListNode node)
    {
      CurrentNode = node;
    }

    public LinkedListNode Current
    {
      get { return CurrentNode; }
    }
    public int Data
    {
      get { return CurrentNode.Data; }
    }
    public LinkedListNode Next()
    {
      CurrentNode = CurrentNode.Next;
      return CurrentNode;
    }

  }
}
