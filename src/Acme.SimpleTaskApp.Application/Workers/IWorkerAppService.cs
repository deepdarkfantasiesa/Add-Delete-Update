using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Workers
{
    public interface IWorkerAppService : IApplicationService
    {
        Task<ListResultDto<WorkerListDto>> GetAll(GetAllWorkersInput input);

        Task<ListResultDto<WorkerListDto>> GetWorker(GetWorkerInput input);

        System.Threading.Tasks.Task<HouseWorker> Create(CreateWorkerInput input);

        System.Threading.Tasks.Task Update(CreateWorkerInput input);

        System.Threading.Tasks.Task Delete(DeleteWorkerInput input);

    }
}
