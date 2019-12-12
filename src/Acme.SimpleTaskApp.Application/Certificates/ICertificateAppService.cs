using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Acme.SimpleTaskApp.Workers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Certificates
{
    public interface ICertificateAppService: IApplicationService
    {
        Task<ListResultDto<CertificateDto>> GetAll();

        System.Threading.Tasks.Task<Certificate> Create(CreateCertificationInput input);

        System.Threading.Tasks.Task Update(CreateCertificationInput input);

        Task<ListResultDto<CertificateDto>> GetCertification(GetCertificationInput input);

        System.Threading.Tasks.Task Delete(DeleteCertificationInput input);
    }
}
