using DeltaSoftTask.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaSoftTask.Core.Interfaces
{
    public interface ITasksRepository: IBaseRepository<Task>
    {
        IEnumerable<Task> GetAllTasksWithMember();
    }
   
}
