using System;
using System.Collections.Generic;

namespace Homework_6
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Stack and Queue
            
           /* Stack<string> stack = new Stack<string>();
            
            List<string> students = new List<string>() 
            { "Вася", "Миша", "Света", "Коля", "Олег", "Вика", "Саша", "Катя", "Иван", "Матвей", "Стефан",
              "Вероника","Люда","Сергей","Яна", "Женя", "Оксна", "Юра", "Настя", "Дима", "Рома", "Анфиса"};
            Random random = new Random();
            int j = 0;
            for (int i = 0; i < 100; i++) 
            {
                var operation = random.Next(2) == 0 ? "push" : "pop";
                if (operation == "push" && j<students.Count)
                {
                    var stackItem = students[j].ToString();
                    stack.Push(stackItem);
                    Console.WriteLine($"Студент {stackItem} сдал домашнее задание");
                    j++;
                }
                else
                {  
                    if (stack.TryPop(out string stackItem))
                    {
                        Console.WriteLine($"Студент {stackItem} получил кофе");
                    }
                    if (j < students.Count && stack.Count == 0 )
                    {
                        Console.WriteLine("Стэк пустой");
                    }
                    if (j>= students.Count)
                    {
                        Console.WriteLine("Все студенты получили кофе");
                        break;
                    }
                }*/

            Queue<string> queue = new Queue<string>();
            List<string> students = new List<string>()
            { "Вася", "Миша", "Света", "Коля", "Олег", "Вика", "Саша", "Катя", "Иван", "Матвей", "Стефан",
              "Вероника","Люда","Сергей","Яна", "Женя", "Оксна", "Юра", "Настя", "Дима", "Рома", "Анфиса"};
            Random random = new Random();
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                var operation = random.Next(2) == 0 ? "enqueue" : "dequeue";
                if (operation == "enqueue" && j < students.Count)
                {
                    var queueItem = students[j].ToString();
                    queue.Enqueue(queueItem);
                    Console.WriteLine($"Студент {queueItem} сдал домашнее задание");
                    j++;
                }
                else
                {
                    if (queue.TryDequeue(out string queueItem))
                    {
                        Console.WriteLine($"Студент {queueItem} получил кофе");
                    }
                    if (j < students.Count && queue.Count == 0)
                    {
                        Console.WriteLine("В очереди никого нет");
                    }
                    if (j >= students.Count)
                    {
                        Console.WriteLine("Все студенты получили кофе");
                        break;
                    }



                }

            }

        }
    }
}
