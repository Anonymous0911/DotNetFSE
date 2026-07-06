using System;

class Program
{
    static void Main()
    {
        TaskLinkedList taskList = new TaskLinkedList();

        taskList.AddTask(new Task(101, "Design Database", "Pending"));
        taskList.AddTask(new Task(102, "Develop API", "In Progress"));
        taskList.AddTask(new Task(103, "Testing", "Pending"));

        taskList.TraverseTasks();

        Task task = taskList.SearchTask(102);

        if (task != null)
        {
            Console.WriteLine("\nTask Found:");
            Console.WriteLine(task);
        }

        taskList.DeleteTask(102);

        Console.WriteLine("\nAfter Deletion:");
        taskList.TraverseTasks();
    }
}