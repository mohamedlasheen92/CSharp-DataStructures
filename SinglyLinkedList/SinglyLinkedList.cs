using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SinglyLinkedList
{
  internal class SinglyLinkedList
  {
    private LinkedListNode Head;
    private LinkedListNode Tail;

    public SinglyLinkedList()
    {
      Head = null;
      Tail = null;
    }

    public void InsertLast(int _data)
    {
      LinkedListNode newNode = new LinkedListNode(_data);
      if (IsEmpty())
      {
        Head = newNode;
        Tail = newNode;
      }
      else
      {
        Tail.Next = newNode;
        Tail = newNode;
      }
    }
    public void InsertAfter(int _target, int _data)
    {
      LinkedListNode node = this.Find(_target);
      LinkedListNode newNode = new LinkedListNode(_data);

      newNode.Next = node.Next;
      node.Next = newNode;
      if (Tail == node)
      {
        Tail = newNode;
      }
    }
    public void InsertBefore(int _target, int _data)
    {
      LinkedListNode node = this.Find(_target);
      if (node == null) return;

      LinkedListNode parent = this.FindParent(_target);
      LinkedListNode newNode = new LinkedListNode(_data);

      newNode.Next = node;
      if (node == Head)
      {
        Head = newNode;
      }
      else
      {
        parent.Next = newNode;
      }

    }
    public void DeleteNode(int _target)
    {
      LinkedListNode node = this.Find(_target);
      if (node == null) return;

      if (Head == Tail)
      {
        Head = null;
        Tail = null;
      }
      else if (Head == node)
      {
        Head = node.Next;
      }
      else
      {
        LinkedListNode parentNode = this.FindParent(_target);
        if (Tail == node)
        {
          Tail= parentNode;
          parentNode.Next = null;
        }else
        {
          parentNode.Next = node.Next;
        }
      }

      node = null;

    }

    public void PrintList()
    {
      for (LinkedListIterator iterator = Begin(); iterator.Current != null; iterator.Next())
      {
        Console.Write($"{iterator.Data} -> ");
      }
      Console.WriteLine();
    }
    private LinkedListIterator Begin()
    {
      LinkedListIterator iterator = new LinkedListIterator(Head);
      return iterator;
    }
    private LinkedListNode Find(int _data)
    {
      for (LinkedListIterator itr = Begin(); itr.Current != null; itr.Next())
      {
        if (itr.Data == _data)
        {
          return itr.Current;
        }
      }
      return null;
    }
    private LinkedListNode FindParent(int _data)
    {
      for (LinkedListIterator iterator = Begin(); iterator.Current != null; iterator.Next())
      {
        if (iterator.Current.Next.Data == _data)
        {
          return iterator.Current;
        }
      }
      return null;
    }
    private bool IsEmpty()
    {
      return Head == null;
    }

  }

}

