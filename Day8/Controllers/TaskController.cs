using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Day8.Entities;
using Day8.DTO;
using Day8.Service;
namespace Day8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private IServiceTask _taskService;
        public TaskController(IServiceTask taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        public void AddTask([FromBody] DTOTask taskModel)
        {
            _taskService.AddTask(taskModel);
        }

        [HttpGet("/GetAllTask")]
        public List<TaskModel> GetAllTask()
        {
            return _taskService.GetAllTask();
        }

        [HttpGet("/GetTaskByID")]
        public TaskModel GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }

        [HttpDelete]
        public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }

        [HttpPut]
        public void EditTask([FromBody] TaskModel model)
        {
            _taskService.EditTask(model);
        }

        [HttpDelete("/DeleteMultiTask")]
        public void DeleteMultiTask(List<int> ids)
        {
            _taskService.DeleteMultipleTasks(ids);
        }

        [HttpPost("/AddMultiTask")]
        public void AddMultiTask([FromBody] List<DTOTask> tasks){
            _taskService.AddMultipleTasks(tasks);
        }
    }
}