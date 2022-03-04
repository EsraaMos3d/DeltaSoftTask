using DeltaSoftTask.Core;
using DeltaSoftTask.Core.Interfaces;
using DeltaSoftTask.Core.Models;
using DeltaSoftTask.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaSoftTask.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Task> Tasks { get; private set; }
        public IBaseRepository<Member> Members { get; private set; }
        public ITasksRepository TasksRepository { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Tasks = new BaseRepository<Task>(_context);
            Members = new BaseRepository<Member>(_context);
            TasksRepository = new TasksRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
