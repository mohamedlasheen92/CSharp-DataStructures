namespace DoublyLinkedList
{
  internal class Program
  {
    static void Main(string[] args)
    {
      DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

      doublyLinkedList.InsertLast(64);
      doublyLinkedList.InsertLast(4);
      doublyLinkedList.InsertLast(6);
      doublyLinkedList.InsertLast(3);

      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      doublyLinkedList.InsertAfter(4, 55);
      doublyLinkedList.InsertAfter(3, 33);
      doublyLinkedList.InsertAfter(64, 66);
      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      doublyLinkedList.InsertBefore(33, 100);
      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      doublyLinkedList.InsertBefore(64, 2);
      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      doublyLinkedList.DeleteNode(2);
      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      doublyLinkedList.DeleteNode(66);
      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      doublyLinkedList.DeleteNode(33);
      Console.WriteLine(doublyLinkedList.Length);
      doublyLinkedList.PrintList();

      Console.WriteLine($"Head: {doublyLinkedList.Head.Data}");
      Console.WriteLine($"Tail: {doublyLinkedList.Tail.Data}");
    }
  }
}
