public class Node
{
    public Task Data;
    public Node Next;

    public Node(Task task)
    {
        Data = task;
        Next = null;
    }
}