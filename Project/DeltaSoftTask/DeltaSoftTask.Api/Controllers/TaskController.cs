using DeltaSoftTask.Core;
using DeltaSoftTask.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeltaSoftTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TaskController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaskController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("GetAll")]
        public IEnumerable<Task> GetAllTasks()
        {
          return  _unitOfWork.TasksRepository.GetAllTasksWithMember().OrderByDescending(a => a.Task_Id);
        }
        [HttpPost("AddTask")]
        public IEnumerable<Task> AddTask(Task task)
        {
            _unitOfWork.TasksRepository.Add(task);
            _unitOfWork.Complete();
            return _unitOfWork.TasksRepository.GetAllTasksWithMember().OrderByDescending(a => a.Task_Id);
        }
        [HttpPost("EditTask")]
        public IEnumerable<Task> EditTask(Task task)
        {
            _unitOfWork.TasksRepository.Update(task);
            _unitOfWork.Complete();
            return _unitOfWork.TasksRepository.GetAllTasksWithMember().OrderByDescending(a => a.Task_Id);
        }
    }
}
