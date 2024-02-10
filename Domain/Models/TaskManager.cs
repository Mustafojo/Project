using System.Dynamic;

public class TaskManager
{
    public List<Task> Tasks { get; set; } = new List<Task>();
    public List<User> Users { get; set; } = new List<User>();
    public List<Category> Categories { get; set; } = new List<Category>();
    public TaskManager()
    {
        
    }
    public TaskManager(List<Task> tasks, List<User> users,List<Category> categories)
    {
        Tasks = tasks;
        Users = users;
        Categories = categories;
    }

}