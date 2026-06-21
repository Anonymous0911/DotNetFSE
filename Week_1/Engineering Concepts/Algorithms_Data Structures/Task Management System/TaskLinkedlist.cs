using System;

public class TaskLinkedList
{
    private Node head;

    // Add Task
    public void AddTask(Task task)
    {
        Node newNode = new Node(task);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    // Search Task
    public Task SearchTask(int id)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Data.TaskId == id)
                return current.Data;

            current = current.Next;
        }

        return null;
    }

    // Traverse Tasks
    public void TraverseTasks()
    {
        Node current = head;

        Console.WriteLine("\nTask List:");

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    // Delete Task
    public void DeleteTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.Data.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task deleted successfully.");
            return;
        }

        Node current = head;

        while (current.Next != null && current.Next.Data.TaskId != id)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Task not found.");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Task deleted successfully.");
        }
    }
}