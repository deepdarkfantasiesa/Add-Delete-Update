using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Certificates
{
    public interface ICertificateAppService: IApplicationService
    {
        Task<ListResultDto<CertificateDto>> GetAll();
    }
}
