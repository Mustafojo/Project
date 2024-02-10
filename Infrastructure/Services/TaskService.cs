
public class TaskServices
{
    List<Task> tasks = new List<Task>();
    List<Category> categories = new List<Category>();
    public List<Task> GetTasks()
    {
        return tasks;
    }
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }
    public Task GetByID(int id)
    {
        var task = tasks.FirstOrDefault(e => e.TaskId == id);
        return task;
    }
    public void UpDateTask(Task task)
    {
        foreach (var item in tasks)
        {
            if (item.TaskId == task.TaskId)
            {
                item.Tittle = task.Tittle;
                item.TaskCategory = task.TaskCategory;
                item.TaskPriority = task.TaskPriority;
                item.Description = task.Description;
                item.Done = task.Done;
                item.Assigne = task.Assigne;
                item.CreatedAt = task.CreatedAt;
                System.Console.WriteLine("Task updated successfully!");
                return;
            }
            System.Console.WriteLine("Task not found!");

        }
    }
    public void DeleteTask(int id)
    {
        var task = tasks.FirstOrDefault(e => e.TaskId == id);
        if (task != null)
        {
            tasks.Remove(task);
            System.Console.WriteLine("Task deleted successfully!");
            return;
        }
        System.Console.WriteLine("Task not found!");
    }
    public void GetInfoAboutTasks()
    {
        foreach (var item in tasks)
        {
            System.Console.WriteLine("Tittle : " + item.Tittle);
            System.Console.WriteLine("Description : " + item.Description);
            System.Console.WriteLine("TaskCategory : " + item.TaskCategory);
            System.Console.WriteLine("TaskPriority : " + item.TaskPriority);
            System.Console.WriteLine("Done : " + item.Done);
            System.Console.WriteLine("Assigne : " + item.Assigne);
            System.Console.WriteLine("CreatedAt : " + item.CreatedAt);
        }
    }
    public List<Task> GetCompletedTasks()
    {
        var task = tasks.FindAll(e => e.Done == true);
        return task;
    }
    public List<Task> GetNotCompletedTasks()
    {
        var task = tasks.FindAll(e => e.Done == false);
        return task;
    }
    public List<Task> GetTaskByCategoryId(Category category)
    {
        var task = tasks.Where(e => e.TaskId == category.CategoryId).ToList();
        return task;
    }
    public List<Task> GetSortedTasks(DateTime createdAt)
    {
        var task = tasks.OrderByDescending(e => e.CreatedAt == createdAt).ToList();
        return task;

    }
    public List<Task> GetTasksByPriority(Priority priority)
    {
        var task = tasks.Where(e => e.TaskPriority == priority).ToList();
        return task;

    }
}











