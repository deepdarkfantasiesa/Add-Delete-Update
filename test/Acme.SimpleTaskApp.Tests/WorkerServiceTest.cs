using Abp.Runtime.Validation;
using Acme.SimpleTaskApp.Tasks;
using Acme.SimpleTaskApp.Workers;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Acme.SimpleTaskApp.Tests
{
    public class WorkerService_Tests : SimpleTaskAppTestBase
    {
        private readonly IWorkerAppService _workService;

        

        public WorkerService_Tests()
        {
            _workService = Resolve<IWorkerAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            //Act
            var output = await _workService.GetAll(new GetAllWorkersInput());

            //Assert
            output.Items.Count.ShouldBe(2);
            output.Items.Count(t => t.Type == 1).ShouldBe(1);
        }

        
        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Filtered_Tasks()
        {
            //Act
            var output = await _workService.GetAll(new GetAllWorkersInput { WorkerType = 1 });

            //Assert
            output.Items.ShouldAllBe(t => t.Type == 1);
            output.Items.Count.ShouldBe(1);
        }

        

        [Fact]
        public async System.Threading.Tasks.Task Should_Create_New_Worker()
        {
            var worker = await _workService.Create(new CreateWorkerInput
            {
                Name = "Worker#1", 
                Age = 31,
                Description = "TestWorker#1",
                WorkArea = "liwan",
                Type = 1,
                Tel = "136",
                IDCard = "4414"
           

            });
            UsingDbContext(context =>
            {
                var task1 = context.Workers.FirstOrDefault(t => t.Name == "Worker#1");
                task1.ShouldNotBeNull();
            });

        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Update_Worker()
        {
            await _workService.Create(new CreateWorkerInput
            {
                Name = "Worker#1",
                Age = 31,
                Description = "TestWorker#1",
                WorkArea = "liwan",
                Type = 1,
                Tel = "136",
                IDCard = "4414"


            });

            UsingDbContext(context =>
            {
                var task1 = context.Workers.FirstOrDefault(t => t.Name == "Worker#1");
                task1.ShouldNotBeNull();
            });

        }
        







    }
}
