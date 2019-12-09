using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Acme.SimpleTaskApp.Workers;
using System;
using System.Collections.Generic;
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
}
