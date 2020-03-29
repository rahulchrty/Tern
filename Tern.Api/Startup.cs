using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Tern.Data;
using Microsoft.EntityFrameworkCore;
using Tern.Interface.Task;
using Tern.Business.Task;
using Tern.Data.TaskRepository;
using Tern.Interface.List;
using Tern.Business.List;
using Tern.Data.ListRepository;
using Tern.Interface.SubTask;
using Tern.Data.SubTaskRepository;
using Tern.Business.SubTask;

namespace Tern.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<TernContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("TernDbConnection")));
            
            services.AddScoped<IRetrieveTask, RetrieveTask>();
            services.AddScoped<IRetrieveActiveTask, RetrieveActiveTask>();
            services.AddScoped<IRetrieveList, RetrieveList>();
            services.AddScoped<ICreateTask, CreateTask>();
            services.AddScoped<IUpdateTask, UpdateTask>();
            services.AddScoped<IDeleteTask, DeleteTask>();
            services.AddScoped<IDeleteBulk, DeleteBulk>();
            services.AddScoped<IMoveTask, MoveTask>();
            services.AddScoped<ITaskStatus, Tern.Business.Task.TaskStatus>();
            services.AddScoped<ICreateSubTask, CreateSubTask>();
            services.AddScoped<IRetrieveSubTask, RetrieveSubTask>();
            services.AddScoped<ISubTaskByTask, SubTaskByTask>();

            services.AddScoped<IRetrieveTaskRepo, RetrieveTaskRepo>();
            services.AddScoped<IRetrieveActiveTaskRepo, RetrieveActiveTaskRepo>();
            services.AddScoped<IRetrieveListRepo, RetrieveListRepo>();
            services.AddScoped<ICreateTaskRepo, CreateTaskRepo>();
            services.AddScoped<IUpdateTaskRepo, UpdateTaskRepo>();
            services.AddScoped<IDeleteTaskRepo, DeleteTaskRepo>();
            services.AddScoped<IMoveTaskRepo, MoveTaskRepo>();
            services.AddScoped<ITaskStatusRepo, TaskStatusRepo>();
            services.AddScoped<ICreateSubTaskRepo, CreateSubTaskRepo>();
            services.AddScoped<IRetrieveSubTaskRepo, RetrieveSubTaskRepo>();
            services.AddScoped<ISubTaskByTaskRepo, SubTaskByTaskRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
