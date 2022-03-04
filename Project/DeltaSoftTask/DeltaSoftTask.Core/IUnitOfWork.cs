using DeltaSoftTask.Core.Interfaces;
using DeltaSoftTask.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaSoftTask.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Task>Tasks { get; }
        IBaseRepository<Member> Members { get; }
        ITasksRepository TasksRepository { get; }

        int Complete();
    }
}
