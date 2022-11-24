using System;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;

            MyLinkedList<string> list = new MyLinkedList<string>();

            while (x != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ввелите код выполнения функции, иначе введите НОЛЬ(!!!!) для выхода из программы:");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: AddElement(list); break;

                    case 2: Push(list); break;

                    case 3: RemoveElement(list); break;

                    case 4: Pop(list); break;

                    case 5: Peek(list); break;

                    case 6: Clear(list); break;

                }
            }
        }

        private static void AddElement(MyLinkedList<string> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Введите сколько элементов будет вставленно в список:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string userInput;
                Console.WriteLine($"Ввод элемента под номером {i} : ");
                userInput = Console.ReadLine();
                list.Add(userInput);
            }

            Console.WriteLine(String.Join(" , ", list));

            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на орецаию: {stopwatch.ElapsedMilliseconds}");
        }

        private static void Push(MyLinkedList<string> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string userInput;
            userInput = Console.ReadLine();
            Console.WriteLine($"Ввод элемента,который хотите вставить вместо головы списка : ");
            list.Push(userInput);

            Console.WriteLine(String.Join(" , ", list));

            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на орецаию: {stopwatch.ElapsedMilliseconds}");
        }

        static void RemoveElement(MyLinkedList<string> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine($"Введите(!!) элемент, который нужно удалить: ");
            string target = Convert.ToString(Console.ReadLine());
            list.Remove(target);

            Console.WriteLine(String.Join(" , ", list));

            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на орецаию: {stopwatch.ElapsedMilliseconds}");

        }

        private static void Pop(MyLinkedList<string> list)
        {
            list.Pop();

            Console.WriteLine(String.Join(" , ", list));
        }

        private static void Peek(MyLinkedList<string> list)
        {
            list.Peek();
        }

        private static void Clear(MyLinkedList<string> list)
        {
            list.Clear();

            Console.WriteLine(String.Join(" , ", list));
        }

    }
}
