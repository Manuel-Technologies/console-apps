using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Runtime.InteropServices;



public class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine($"welcome to taskFlow ...the best task management app in the world");

        List<Task> tasks = new List<Task>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Edit tasks");
            Console.WriteLine("5. Exit");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    ViewTasks(tasks);
                    break;
                case "3":
                    isRunning = false;
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;

                    case "4"
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

    }
}