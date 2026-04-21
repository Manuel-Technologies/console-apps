using System.Security.Cryptography.X509Certificates;

public class TaskManager
{
    private List<Tasks> tasks;

    public TaskManager()
    {
        tasks = new List<Tasks>();
    }

    public void AddTask(Tasks task)
    {
        tasks.Add(task);
        Console.WriteLine("Task added successfully.");
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("\nTasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"Title: {task.TaskTitle}");
            Console.WriteLine($"Body: {task.TaskBody}");
            Console.WriteLine($"Status: {task.TaskStatus}");
            Console.WriteLine($"Due Date: {task.TaskDueDate}");
            Console.WriteLine($"Created Date: {task.TaskCreatedDate}");
            Console.WriteLine($"Updated Date: {task.TaskUpdatedDate}");
            Console.WriteLine($"Priority: {task.TaskPriority}");
            Console.WriteLine($"Category: {task.TaskCategory}");
            Console.WriteLine();
        }

    
    }

    public void DeleteTask(string title)
    {
        var taskToRemove = tasks.FirstOrDefault(t => t.TaskTitle == title);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }   
}