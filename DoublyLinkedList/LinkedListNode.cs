using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
  internal class LinkedListNode
  {
    public int Data;
    public LinkedListNode Next;
    public LinkedListNode Back;

    public LinkedListNode(int _data)
    {
      Data = _data;
      Next = null;
      Back = null;
    }
  }
}
