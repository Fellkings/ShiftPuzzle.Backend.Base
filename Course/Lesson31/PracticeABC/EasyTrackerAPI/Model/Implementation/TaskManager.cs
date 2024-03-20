
public class TaskManager : ITaskManager
{
    private ITaskRepository _taskRepository;

    public TaskManager(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }   
    public void AddTask(TrackerTask task)
    { 
        _taskRepository.AddTask(task);
    }

    public void DeleteTask(int taskId)
    { 
        _taskRepository.DeleteTask(taskId);
    } 

    public List<TrackerTask> GetAllTasks()
    { 
        return _taskRepository.GetAllTasks();
    }

    public TrackerTask GetTaskById(int taskId)
    { 
        return _taskRepository.GetTaskById(taskId);
    }

    public void CompleteTask(int id)
    {
        _taskRepository.CompleteTaskById(id);
    }
}