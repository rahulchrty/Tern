﻿using Tern.Data.ListRepository;
using Tern.Data.SubTaskRepository;
using Tern.Data.TaskRepository;
using Tern.Interface.List;
using Tern.Interface.SubTask;
using Tern.Interface.Task;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoryServiceExtention
    {
        public static IServiceCollection AddRepositoryService (this IServiceCollection services)
        {
            services.AddScoped<IRetrieveTaskRepo, RetrieveTaskRepo>();
            services.AddScoped<IRetrieveActiveTaskRepo, RetrieveActiveTaskRepo>();
            services.AddScoped<ICreateTaskRepo, CreateTaskRepo>();
            services.AddScoped<IUpdateTaskRepo, UpdateTaskRepo>();
            services.AddScoped<IDeleteTaskRepo, DeleteTaskRepo>();
            services.AddScoped<IMoveTaskRepo, MoveTaskRepo>();
            services.AddScoped<ITaskStatusRepo, TaskStatusRepo>();

            services.AddScoped<IRetrieveListRepo, RetrieveListRepo>();

            services.AddScoped<ICreateSubTaskRepo, CreateSubTaskRepo>();
            services.AddScoped<IRetrieveSubTaskRepo, RetrieveSubTaskRepo>();
            services.AddScoped<ISubTaskByTaskRepo, SubTaskByTaskRepo>();
            services.AddScoped<IDeleteSubTaskRepo, DeleteSubTaskRepo>();
            return services;
        }
    }
}