public class Tasks
{
    public string?  TaskTitle {get;set;}
    public string?  TaskBody {get;set;}
    public string?  TaskStatus {get;set;}
    public DateTime TaskDueDate {get;set;}
    public DateTime TaskCreatedDate {get;set;}
    public DateTime TaskUpdatedDate {get;set;}
    public string?  TaskPriority {get;set;}
    public string?  TaskCategory {get;set;}

    public Tasks(string? title, string? body, string? status, DateTime dueDate, DateTime createdDate, DateTime updatedDate, string? priority, string? category)
    {
        TaskTitle = title;
        TaskBody = body;
        TaskStatus = status;
        TaskDueDate = dueDate;
        TaskCreatedDate = createdDate;
        TaskUpdatedDate = updatedDate;
        TaskPriority = priority;
        TaskCategory = category;
    }



}