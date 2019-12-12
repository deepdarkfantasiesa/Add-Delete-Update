using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Acme.SimpleTaskApp.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.SimpleTaskApp.Certificates
{
    [AutoMapFrom(typeof(Certificate))]
    public class CertificateDto: EntityDto, IHasCreationTime
    {
        public string Certification { get; set; }
        public DateTime CreationTime { get; set; }
        public int WorkerID { get; set; }
    }

    [AutoMapTo(typeof(Certificate))]
    public class CreateCertificationInput
    {
        public const int MaxLength = 256;

        [Required]
        [StringLength(MaxLength)]
        public string Certification { get; set; }


        public DateTime CreationTime { get; set; }

        public int WorkerID { get; set; }//这里可能会有问题

        public int Id { get; set; }
    }

    public class GetCertificationInput
    {
        public int CertId { get; set; }//这里可能有问题
    }

    public class DeleteCertificationInput
    {
        public int Id { get; set; }
    }
}
