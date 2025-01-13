using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
  internal class LinkedListIterator
  {
    public LinkedListNode CurrentNode;

    public LinkedListIterator()
    {
      CurrentNode = null;
    }
    public LinkedListIterator(LinkedListNode node)
    {
      CurrentNode = node;
    }

    public int Data
    {
      get
      {
        return CurrentNode.Data;
      }
    }
    public LinkedListNode Current
    {
      get
      {
        return CurrentNode;
      }
    }
    public LinkedListIterator Next()
    {
      CurrentNode = CurrentNode.Next;
      return this;
    }
  }
}
