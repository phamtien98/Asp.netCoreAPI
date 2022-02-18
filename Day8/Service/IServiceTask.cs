using Day8.DTO;
using Day8.Entities;
namespace Day8.Service
{
    public interface IServiceTask
    {
        void AddTask(DTOTask model);
        TaskModel GetTaskById(int id);
        List<TaskModel> GetAllTask();
        void DeleteTask (int id);
        void EditTask(TaskModel model );
        void DeleteMultipleTasks(List<int> ids); 
        void AddMultipleTasks(List<DTOTask> tasks);
    }
}