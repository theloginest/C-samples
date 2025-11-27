using System;
using System.Collections.Generic;

class Program
{
    static List<string> todoList = new List<string>();

    static void ShowMenu()
    {
        Console.WriteLine("\n--- TODO MENU ---");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Remove Task");
        Console.WriteLine("3. Show Tasks");
        Console.WriteLine("4. Exit");
    }

    static void AddTask()
    {
        Console.Write("Enter a new task: ");
        string task = Console.ReadLine();
        todoList.Add(task);
        Console.WriteLine("Task added!");
    }

    static void RemoveTask()
    {
        Console.Write("Enter task to remove: ");
        string task = Console.ReadLine();
        if (todoList.Remove(task))
            Console.WriteLine("Task removed!");
        else
            Console.WriteLine("Task not found.");
    }

    static void ShowTasks()
    {
        if (todoList.Count == 0)
            Console.WriteLine("No tasks yet.");
        else
        {
            Console.WriteLine("\nYour Tasks:");
            for (int i = 0; i < todoList.Count; i++)
                Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
    }

    static void Main()
    {
        while (true)
        {
            ShowMenu();
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddTask();
            else if (choice == "2") RemoveTask();
            else if (choice == "3") ShowTasks();
            else if (choice == "4") break;
            else Console.WriteLine("Invalid choice, try again.");
        }
    }
}
