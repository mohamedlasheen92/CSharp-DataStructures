using SinglyLinkedList;

namespace Stack
{
  /*
   * InsertFirst(data) in LinkedList
   */
  internal class Program
  {
    static void Main(string[] args)
    {
      StackList stack = new StackList();

      Console.WriteLine(stack.IsEmpty());
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Console.WriteLine(stack.Size());
      stack.Print();

      Console.WriteLine(stack.Peek());
      Console.WriteLine(stack.Size());
      stack.Print();

      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Size());
      stack.Print();

    }
  }
}
