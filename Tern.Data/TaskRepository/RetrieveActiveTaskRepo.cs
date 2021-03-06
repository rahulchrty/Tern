﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Data.TaskRepository
{
    public class RetrieveActiveTaskRepo : IRetrieveActiveTaskRepo
    {
        private TernContext _ternContext;
        public RetrieveActiveTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<List<TaskModel>> GetActiveTasks()
        {
            var searchedTask = await (from task in _ternContext.Tasks
                                      where task.StatusId == 1
                                      select new TaskModel
                                      {
                                          TaskId = task.TaskId,
                                          Description = task.Description,
                                          Status = new StatusModel
                                          {
                                              StatusId = task.StatusId,
                                              StatusType = task.Status.StatusType
                                          },
                                          TaskName = task.TaskName,
                                          List = new ListModel
                                          {
                                              ListId = task.List.ListId,
                                              ListName = task.List.ListName
                                          }
                                      }).ToListAsync();
            return searchedTask;
        }
    }
}
