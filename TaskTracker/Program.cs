
using System;
using System.Collections.Generic;


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

List<string> tasks = new List<string>();
List<string> fineshedtaskes = new List<string>();
bool running = true;
while (running)
{
    Console.WriteLine(" My Task list");
    Console.WriteLine("1. add task");
    Console.WriteLine("2. show tasks");
    Console.WriteLine("3. finsh task");
    Console.WriteLine("4. show tasks finshed");
    Console.WriteLine("5. Exit");

    Console.Write("     Choose: ");

    string choice = Console.ReadLine()!;

    if (choice == "1")
    {
        Console.Write("Enter task: ");
        string task = Console.ReadLine()!;

        tasks.Add(task);

        Console.WriteLine("Task added!");
    }
    else if (choice == "2")
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine( tasks[i]);
            }
        }
    }
    else if (choice == "3")
    {
        Console.Write("enter task name :");
        string finesedtask = Console.ReadLine()!;

        if (tasks.Contains(finesedtask))
        {
            fineshedtaskes.Add(finesedtask);
            Console.WriteLine("TASK ADDED TO FINSH LIST");


        }
        else
        {
            Console.WriteLine("THE TASK NOT FOUND IN LIST TASK !!");
        }

    }
    else if (choice == "4")

    {
        if (fineshedtaskes.Count == 0)
        {
            Console.WriteLine("no fineshed task");

        }
        else
        {
            for (int a = 0; a< fineshedtaskes.Count ; a++)
            {
                Console.WriteLine( fineshedtaskes[a]);

            }

        }
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






