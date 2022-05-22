using System;

namespace AIS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            // добавление элементов
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n ");
            // удаляем элемент
            linkedList.Remove("Alice");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n ");
            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("Bill");

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
