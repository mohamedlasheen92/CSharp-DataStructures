using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
  internal class LinkedListNode
  {
    public int Data { get; set; }
    public LinkedListNode Next { get; set; }

    public LinkedListNode(int _data)
    {
      Data = _data;
      Next = null;
    }

  }
}
