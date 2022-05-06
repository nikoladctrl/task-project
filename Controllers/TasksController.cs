using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Services.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TasksController : BaseApiController
    {
        private readonly ITaskService _taskService;
        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }


        [HttpGet]
        public async Task<ActionResult<List<MyTask>>> GetTasks()
        {
            var tasks = await _taskService.GetTasks();

            return (tasks == null) ?
                NotFound() : 
                Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MyTask>> GetTask([FromRoute] int id)
        {
            var task = await _taskService.GetTask(id);

            return (task == null) ?
                NotFound() :
                Ok(task);
        }
    }
}