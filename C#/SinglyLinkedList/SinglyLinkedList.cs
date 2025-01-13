namespace SinglyLinkedList
{
  public class SingleLinkedList
  {
    public LinkedListNode Head;
    public LinkedListNode Tail;
    public int Length;

    public SingleLinkedList()
    {
      Head = null;
      Tail = null;
      Length = 0;
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

      Length++;
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
      Length++;
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
      Length++;
    }
    public void InsertFirst(int _data)
    {
      LinkedListNode newNode = new LinkedListNode(_data);
      if (Head == null)
        Head = newNode;
      else
      {
        newNode.Next = Head;
        Head = newNode;
      }
      Length++;
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
      Length++;
    }
    public void DeleteHead()
    {
      if (Head == null) return;
      Head = Head.Next;

      Length--;
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

