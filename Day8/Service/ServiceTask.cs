using Day8.Entities;
using Day8.Data;
using Day8.DTO;
namespace Day8.Service
{
    public class ServiceTask : IServiceTask
    {
        private TaskContext _context;
        public ServiceTask(TaskContext context)
        {
            _context = context;
        }

        public void AddTask(DTOTask model)
        {
            _context.Add(new TaskModel { Title = model.Title, IsCompleted = model.IsCompleted });
            _context.SaveChanges();
        }

        public TaskModel GetTaskById(int id)
        {
            return _context.Tasks.FirstOrDefault(m => m.Id == id);
        }
        public List<TaskModel> GetAllTask()
        {
            return _context.Tasks.ToList();
        }
        public void DeleteTask(int id)
        {
            var item = _context.Tasks.FirstOrDefault(m => m.Id == id);

            if (item != null)
            {
                _context.Tasks.Remove(item);
                _context.SaveChanges();
            }
        }
        public void EditTask(TaskModel task)
        {
            var item = _context.Tasks.FirstOrDefault(m => m.Id == task.Id);

            if (item != null)
            {
                item.Title = task.Title;
                item.IsCompleted = task.IsCompleted;
                _context.SaveChanges();
            }
        }

        public void DeleteMultipleTasks(List<int> ids)
        {
            var foundTasks = _context.Tasks.Where(task => ids.Contains(task.Id));

            if (foundTasks.Any())
            {
                _context.Tasks.RemoveRange(foundTasks);
                _context.SaveChanges();
            }
        }

        public void AddMultipleTasks(List<DTOTask> tasks)
        {
            foreach (var item in tasks)
            {
                _context.Add(new TaskModel { Title = item.Title, IsCompleted = item.IsCompleted });
                _context.SaveChanges();
            }
        }
    }
}