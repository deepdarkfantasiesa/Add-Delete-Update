using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Acme.SimpleTaskApp.Workers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Certificates
{
    public class CertificateAppService : SimpleTaskAppAppServiceBase, ICertificateAppService
    {
        private readonly IRepository<Certificate> _certificateRepository;

        public CertificateAppService(IRepository<Certificate> certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }

        public async Task<ListResultDto<CertificateDto>> GetAll()
        {
            var certificates = await _certificateRepository
                .GetAll()
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<CertificateDto>(
                ObjectMapper.Map<List<CertificateDto>>(certificates)
            );
        }


    }
}
