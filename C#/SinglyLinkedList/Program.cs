namespace SinglyLinkedList
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SingleLinkedList singlyLinkedList = new SingleLinkedList();
      singlyLinkedList.InsertLast(1);
      singlyLinkedList.InsertLast(14);
      singlyLinkedList.InsertLast(15);
      singlyLinkedList.InsertLast(10);
      singlyLinkedList.InsertLast(94);

      singlyLinkedList.PrintList();

      singlyLinkedList.InsertAfter(94, 90);
      singlyLinkedList.PrintList();

      singlyLinkedList.InsertBefore(10, 65);
      singlyLinkedList.PrintList();

      singlyLinkedList.DeleteNode(90);
      singlyLinkedList.PrintList();




    }
  }
}
