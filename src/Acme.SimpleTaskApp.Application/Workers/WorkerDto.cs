using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.SimpleTaskApp.Workers
{
    public class GetAllWorkersInput
    {
        public int? WorkerType { get; set; }
    }

    public class GetWorkerInput
    {
        public int WorkerId { get; set; }
    }

    [AutoMapFrom(typeof(HouseWorker))]
    public class WorkerListDto : EntityDto, IHasCreationTime
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Type { get; set; }

        public string WorkArea { get; set; }

        public string Description { get; set; }

        public string Tel { get; set; }

        public DateTime CreationTime { get; set; }

        public string IDCard { get; set; }

    }

    [AutoMapTo(typeof(HouseWorker))]
    public class CreateWorkerInput
    {
        [Required]
        [StringLength(HouseWorker.MaxLength)]
        public string Name { get; set; }

        public int Age { get; set; }

        public int Type { get; set; }

        public string WorkArea { get; set; }

        [StringLength(HouseWorker.MaxDescriptionLength)]
        public string Description { get; set; }

        public string Tel { get; set; }

        [Required]
        [StringLength(HouseWorker.MaxLength)]
        public string IDCard { get; set; }

        public int Id { get; set; }
    }

    public class DeleteWorkerInput
    {
        public int Id { get; set; }

    }
    }
