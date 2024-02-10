public class Task
{
    public int TaskId { get; set; }
    public string Tittle { get; set; }
    public string Description { get; set; }
    public User Assigne { get; set; }
    public Category TaskCategory { get; set; }
    public Priority TaskPriority { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; set; }
    public Task()
    {
        
    }
    public Task(int taskid,string tittle,string description,User assigne,Category taskcategoty,DateTime createdat)
    {
        TaskId = taskid;
        Tittle = tittle;
        Description = description;
        Assigne = assigne;
        TaskCategory = taskcategoty;
        CreatedAt = createdat;
    }
}