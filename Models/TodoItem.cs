namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long Age { get; set; }
    public bool IsComplete { get; set; }
}