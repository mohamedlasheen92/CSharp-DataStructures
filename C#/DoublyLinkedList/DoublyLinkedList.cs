using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
  internal class DoublyLinkedList
  {
    public LinkedListNode Head;
    public LinkedListNode Tail;
    public int Length;

    public DoublyLinkedList()
    {
      Head = null;
      Tail = null;
      Length = 0;
    }

    private LinkedListIterator Begin()
    {
      LinkedListIterator iterator = new LinkedListIterator(Head);
      return iterator;
    }
    public void InsertLast(int _newData)
    {
      LinkedListNode newNode = new LinkedListNode(_newData);

      if (Head == null)
      {
        Head = newNode;
        Tail = newNode;
      }
      else
      {
        Tail.Next = newNode;
        newNode.Back = Tail;
        Tail = newNode;
      }
      Length++;
    }
    public void InsertAfter(int _data, int _newData)
    {
      LinkedListNode node = this.Find(_data);
      if (node == null) return;

      LinkedListNode newNode = new LinkedListNode(_newData);

      newNode.Next = node.Next;
      node.Next = newNode;
      newNode.Back = node;
      if (newNode.Next == null)
      {
        Tail = newNode;
      }
      else
      {
        newNode.Next.Back = newNode;
      }
      Length++;
    }
    public void InsertBefore(int _data, int _newData)
    {
      LinkedListNode node = this.Find(_data);
      if (node == null) return;

      LinkedListNode newNode = new LinkedListNode(_newData);
      newNode.Next = node;

      if (Head == node)
      {
        Head = newNode;
      }
      else
      {
        node.Back.Next = newNode;
        newNode.Back = node.Back;
      }
      node.Back = newNode;

      Length++;
    }
    public void DeleteNode(int _data)
    {
      LinkedListNode node = this.Find(_data);
      if (node == null) return;

      if (Head == Tail)
      {
        Head = null;
        Tail = null;
      }
      else if (Tail == node)
      {
        Tail = node.Back;
        Tail.Next = null;
      }
      else if (node.Back == null)
      {
        Head = Head.Next;
        Head.Back = null;
      }
      else
      {
        node.Back.Next = node.Next;
        node.Next.Back = node.Back;
      }

      node = null;
      Length--;
    }

    public void PrintList()
    {
      for (LinkedListIterator itr = Begin(); itr.Current != null; itr.Next())
      {
        Console.Write($"{itr.Data} -> ");
      }
      Console.WriteLine();
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
  }
}
