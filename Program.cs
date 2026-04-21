using System.Linq.Expressions;

public class MainApp 
{
    public static void Main(string[] args)
    {
     
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string? option = Console.ReadLine();

            TaskManager taskManager = new TaskManager();

            switch (option)
            {
                case "1":
                    Console.Write("Enter task title: ");
                    string? title = Console.ReadLine();
                    Console.Write("Enter task body: ");
                    string? body = Console.ReadLine();
                    Console.Write("Enter task status: ");
                    string? status = Console.ReadLine();
                    Console.Write("Enter task due date (yyyy-MM-dd): ");
                    DateTime dueDate = DateTime.Parse(Console.ReadLine()!);
                    DateTime createdDate = DateTime.Now;
                    DateTime updatedDate = DateTime.Now;
                    Console.Write("Enter task priority: ");
                    string? priority = Console.ReadLine();
                    Console.Write("Enter task category: ");
                    string? category = Console.ReadLine();

                    Tasks newTask = new Tasks(title, body, status, dueDate, createdDate, updatedDate, priority, category);
                    taskManager.AddTask(newTask);
                    break;

                case "2":
                    taskManager.ViewTasks();
                    break;

                case "3":
                    Console.Write("Enter the title of the task to delete: ");
                    string? deleteTitle = Console.ReadLine();
                    taskManager.DeleteTask(deleteTitle!);
                    break;

                case "4":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }



    }
}