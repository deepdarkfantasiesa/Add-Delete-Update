using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Acme.SimpleTaskApp.Workers
{
    public class WorkerAppService : SimpleTaskAppAppServiceBase, IWorkerAppService
    {
        private readonly IRepository<HouseWorker> _workerRepository;

        public WorkerAppService(IRepository<HouseWorker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<ListResultDto<WorkerListDto>> GetAll(GetAllWorkersInput input)
        {
            var workers = await _workerRepository
                .GetAll()
                .WhereIf(input.WorkerType.HasValue, t => t.Type == input.WorkerType.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<WorkerListDto>(
                ObjectMapper.Map<List<WorkerListDto>>(workers)
            );
        }


        public async Task<ListResultDto<WorkerListDto>> GetWorker(GetWorkerInput input)
        {
            var workers = await _workerRepository
                .GetAll()
                .Where(t => t.Id == input.WorkerId)
                .ToListAsync();

            return new ListResultDto<WorkerListDto>(
                ObjectMapper.Map<List<WorkerListDto>>(workers)
            );
        }

        

        public async System.Threading.Tasks.Task<HouseWorker> Create(CreateWorkerInput input)
        {
            Logger.Info("Create" + input.ToString());
            var worker = ObjectMapper.Map<HouseWorker>(input);
            var worker2 = await _workerRepository.InsertAsync(worker);
            return worker2;
        }

        public async System.Threading.Tasks.Task Update(CreateWorkerInput input)
        {
            Logger.Info("Update" + input.ToString());
            var worker = ObjectMapper.Map<HouseWorker>(input);
            await _workerRepository.UpdateAsync(worker);
        }

        public async System.Threading.Tasks.Task Delete(DeleteWorkerInput input)
        {
            Logger.Info("Delete " + input.ToString());

            var worker = new HouseWorker()
            {
                Id = input.Id
            };

            await _workerRepository.DeleteAsync(worker);
        }
    }
}