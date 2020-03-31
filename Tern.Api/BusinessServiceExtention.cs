using Tern.Business.List;
using Tern.Business.Status;
using Tern.Business.SubTask;
using Tern.Business.Task;
using Tern.Interface.List;
using Tern.Interface.Status;
using Tern.Interface.SubTask;
using Tern.Interface.Task;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BusinessServiceExtention
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection services)
        {
            services.AddScoped<IRetrieveTask, RetrieveTask>();
            services.AddScoped<IRetrieveActiveTask, RetrieveActiveTask>();
            services.AddScoped<ICreateTask, CreateTask>();
            services.AddScoped<IUpdateTask, UpdateTask>();
            services.AddScoped<IDeleteTask, DeleteTask>();
            services.AddScoped<IDeleteBulk, DeleteBulk>();
            services.AddScoped<IMoveTask, MoveTask>();
            services.AddScoped<ITaskStatus, TaskStatus>();

            services.AddScoped<IRetrieveList, RetrieveList>();
            services.AddScoped<IRetrieveListById, RetrieveListById>();
            services.AddScoped<ICreateList, CreateList>();
            services.AddScoped<IUpdateList, UpdateList>();

            services.AddScoped<ICreateSubTask, CreateSubTask>();
            services.AddScoped<IRetrieveSubTask, RetrieveSubTask>();
            services.AddScoped<ISubTaskByTask, SubTaskByTask>();
            services.AddScoped<IDeleteSubTask, DeleteSubTask>();
            services.AddScoped<IUpdateSubTaskTitle, UpdateSubTaskTitle>();

            services.AddScoped<IRetrieveStatus, RetrieveStatus>();
            services.AddScoped<IDeleteList, DeleteListWithTask>();
            services.AddScoped<IDeleteList, DeleteOnlyList>();
            services.AddScoped<IDeleteListFlow, DeleteListFlow>();
            return services;
        }
    }
}
