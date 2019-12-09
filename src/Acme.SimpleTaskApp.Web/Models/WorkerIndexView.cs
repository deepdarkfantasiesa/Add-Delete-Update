using Abp.Localization;
using Acme.SimpleTaskApp.Tasks;
using Acme.SimpleTaskApp.Workers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acme.SimpleTaskApp.Web.Models
{
    public class WorkerIndexViewModel
    {
        public IReadOnlyList<WorkerListDto> Workers{ get; }

        public WorkerIndexViewModel(IReadOnlyList<WorkerListDto> workers)
        {
            Workers = workers;
        }

        public string GetWorkerLabel(WorkerListDto worker)
        {
            switch (worker.Type)
            {
                case 1:
                    return "HouseKeeper";
                default:
                    return "Security";
            }
        }


        public int? SelectedType { get; set; }



    }
}