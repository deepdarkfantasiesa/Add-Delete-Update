using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Acme.SimpleTaskApp.Tasks;
using Acme.SimpleTaskApp.Web.Models;
using Acme.SimpleTaskApp.Workers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Acme.SimpleTaskApp.Web.Controllers
{
    public class WorkersController : SimpleTaskAppControllerBase
    {
        private readonly IWorkerAppService _workerService;



        public WorkersController(IWorkerAppService workerService)
        {
            _workerService = workerService;
        
        }

        public async Task<ActionResult> Index(GetAllWorkersInput input)
        {

            var output = await _workerService.GetAll(input);
            var model = new WorkerIndexViewModel(output.Items)
            {
                SelectedType = input.WorkerType
            };
            return View(model);
        }

        public async Task<ActionResult> Update(GetWorkerInput input)
        {
            var output = await _workerService.GetWorker(input);
            var model = new WorkerIndexViewModel(output.Items);
            return View(model);
        }




        public ActionResult Create()
        {
            return View();
        }
    }
}