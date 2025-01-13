using SinglyLinkedList;

namespace Stack
{
  //Stack - LinkedList Based
  internal class StackList
  {
    private SingleLinkedList dataList;
    public StackList()
    {
      dataList = new SingleLinkedList();
    }

    public void Push(int _data)
    {
      dataList.InsertFirst(_data);
    }
    public int Pop()
    {
      int headData = dataList.Head.Data;
      dataList.DeleteHead();
      return headData;
    }
    public int Peek()
    {
      return dataList.Head.Data;
    }
    public int Size()
    {
      return dataList.Length;
    }
    public bool IsEmpty()
    {
      return dataList.Length <= 0;
    }
    public void Print()
    {
      dataList.PrintList();
    }
  }
}
