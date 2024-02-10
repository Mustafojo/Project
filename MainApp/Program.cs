var task = new TaskServices();
while (true)
{
    Console.WriteLine("Commands :");
    Console.WriteLine("Show all Tasks enter show");
    Console.WriteLine("Add a new task enter add");
    Console.WriteLine("Find a task (by id) enter ById");
    Console.WriteLine("Update task enter update");
    Console.WriteLine("Delete task enter delete");
    Console.WriteLine("Get information about tasks enter about");
    Console.WriteLine("Get completed tasks enter comtask");
    Console.WriteLine("Get not completed tasks enter not notcomtask");
    Console.WriteLine("Get sort tasks sort");
    Console.WriteLine("Get tasks by priority priority");
    Console.WriteLine("For endind project enter end");
    Console.Write("Enter the command : ");
    string command = Console.ReadLine();
    if (command == "show")
    {
        Console.WriteLine("---------------------------------------");
        foreach (var item in task.GetTasks())
        {
            Console.WriteLine("Title : " + item.Tittle);
            Console.WriteLine("Description : " + item.Description);
            Console.WriteLine("Assegnee : " + item.Assigne);
            Console.WriteLine("Category : " + item.TaskCategory);
            Console.WriteLine("Priority : " + item.TaskPriority);
            Console.WriteLine("Done : " + item.Done);
            Console.WriteLine("Created date : " + item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter end for back to menu : ");
    }
    else if (command == "add")
    {
        Console.WriteLine("---------------------------------------");
        var taskk = new Task();
        Console.Write("Enter a taskk title : ");
        taskk.Tittle = Console.ReadLine();
        Console.Write("Enter a taskk description : ");
        taskk.Description = Console.ReadLine();
        Console.Write("Enter who  must do this taskk : ");
        var user = new User();
        user.UserName = Console.ReadLine();
        user.UserId = 1;
        taskk.Assigne = user;
        var categ = new Category();
        categ.CategoryId = 1;
        Console.Write("Enter a taskk category name : ");
        categ.CategoryName = Console.ReadLine();
        taskk.TaskCategory = categ;
        Console.WriteLine("Enter the priority of the taskk (1: Low, 2: Medium, 3: High) : ");
        int priorityInput = Convert.ToInt32(Console.ReadLine());
        Enum.IsDefined(typeof(Priority), priorityInput);
        taskk.TaskPriority = (Priority)priorityInput;
        taskk.Done = false;
        Console.WriteLine("Enter time of create");
        taskk.CreatedAt = Convert.ToDateTime(Console.ReadLine());
        task.AddTask(taskk);
        Console.WriteLine("Task created succesfuly!!!");
        Console.Write("Enter end for back to menu : ");
        Console.WriteLine("---------------------------------------");
    }
    else if (command == "ById")
    {
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter a task ID :");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(task.GetByID(id));
        Console.Write("Enter any KEY for back to menu : ");
        Console.WriteLine("---------------------------------------");
    }
    else if (command == "GetByID")
    {
        Console.WriteLine("---------------------------------------");
        var task1 = new Task();
        Console.Write("Enter task1 id which you want to change : ");
        task1.TaskId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a task1 new title : ");
        task1.Tittle = Console.ReadLine();
        Console.Write("Enter a task1  new description : ");
        task1.Description = Console.ReadLine();
        Console.WriteLine("Enter new name who  must dothis task1 : ");
        var user = new User();
        user.UserName = Console.ReadLine();
        user.UserId = 1;
        task1.Assigne = user;

        var categ = new Category();
        categ.CategoryId = 1;
        Console.Write("Enter a task new category name : ");
        categ.CategoryName = Console.ReadLine();
        task1.TaskCategory = categ;
        Console.WriteLine("Enter the new priority of the task (1: Low, 2: Medium, 3: High) : ");
        int priorityInput = Convert.ToInt32(Console.ReadLine());
        Enum.IsDefined(typeof(Priority), priorityInput);
        task1.TaskPriority = (Priority)priorityInput;
        task1.Done = false;
        Console.WriteLine("Enter time of create");
        task1.CreatedAt = DateTime.Now;
        task.AddTask(task1);
        Console.WriteLine("Task Updated succesfuly!!!");
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter any KEY for back to menu : ");
        Console.ReadKey();
    }
    else if (command == "delete")
    {
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter a task ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter any KEY for back to menu : ");
        Console.ReadKey();
    }
    else if (command == "about")
    {
        Console.WriteLine("---------------------------------------");
        task.GetInfoAboutTasks();
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter any KEY for back to menu : ");
        Console.ReadKey();
    }
    else if (command == "comtask")
    {
        Console.WriteLine("---------------------------------------");
        foreach (var item in task.GetCompletedTasks())
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Tittle);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assigne);
            Console.WriteLine(item.TaskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }
    else if (command == "notcomtask")
    {
        Console.WriteLine("---------------------------------------");
        foreach (var item in task.GetNotCompletedTasks())
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Tittle);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assigne);
            Console.WriteLine(item.TaskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }
    else if (command == "sort")
    {
        Console.WriteLine("---------------------------------------");
        foreach (var item in task.GetSortedTasks(new DateTime(2024, 12, 28)))
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Tittle);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assigne);
            Console.WriteLine(item.TaskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");

    }
    else if (command == "priority")
    {
        Console.WriteLine("---------------------------------------");
        int priorityInput = Convert.ToInt32(Console.ReadLine());
        Enum.IsDefined(typeof(Priority), priorityInput);
        foreach (var item in task.GetTasksByPriority((Priority)priorityInput))
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Tittle);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assigne);
            Console.WriteLine(item.TaskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }

}