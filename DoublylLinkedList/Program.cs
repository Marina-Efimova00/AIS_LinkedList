
using System;

namespace DoublylLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
            // добавление элементов
            linkedList.Add("Bob");
            linkedList.Add("Bill");
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n ");
            // удаление
            linkedList.Remove("Bill");

            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n ");
            // перебор с последнего элемента
            foreach (var t in linkedList.BackEnumerator())
            {
                Console.Write(t + " ");
            }
        }
    }
}
