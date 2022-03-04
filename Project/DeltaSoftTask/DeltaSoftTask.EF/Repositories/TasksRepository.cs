using DeltaSoftTask.Core.Interfaces;
using DeltaSoftTask.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaSoftTask.EF.Repositories
{
    public class TasksRepository : BaseRepository<Task>, ITasksRepository
    {
        private readonly ApplicationDbContext _context;
        public TasksRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Task> GetAllTasksWithMember()
        {
            return _context.Tasks.Include("Member");
        }
    }
}
