
using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();
    static List<string> finishedTasks = new List<string>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n My Task List");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Show tasks");
            Console.WriteLine("3. Finish task");
            Console.WriteLine("4. Show finished tasks");
            Console.WriteLine("5. Exit");

            Console.Write("Choose: ");
            string choice = validinput();

            if (choice == "1")
            {
                AddTask();
            }
            else if (choice == "2")
            {
                ShowTasks();
            }
            else if (choice == "3")
            {
                FinishTask();
            }
            else if (choice == "4")
            {
                ShowFinishedTasks();
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Wrong choice.");
            }
        }
    }

    static string validinput()
    {
        string input = Console.ReadLine() ?? "";

        while (input.Trim() == "")
        {
            Console.WriteLine("Input cannot be empty. Try again:");
            input = Console.ReadLine() ?? "";
            
        }

        return input.Trim();
    }

    static void AddTask()
    {
        Console.Write("Enter task: ");
        string task = validinput();

        tasks.Add(task);

        Console.WriteLine("Task added!");
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }

    static void FinishTask()
    {
        Console.Write("Enter task name: ");
        string task = validinput();

        if (tasks.Contains(task))
        {
            tasks.Remove(task);
            finishedTasks.Add(task);

            Console.WriteLine("Task finished!");
        }
        else
        {
            Console.WriteLine("Task not found in task list!");
        }
    }

    static void ShowFinishedTasks()
    {
        if (finishedTasks.Count == 0)
        {
            Console.WriteLine("No finished tasks.");
        }
        else
        {
            for (int i = 0; i < finishedTasks.Count; i++)
            {
                Console.WriteLine(finishedTasks[i]);
            }
        }
    }
}

