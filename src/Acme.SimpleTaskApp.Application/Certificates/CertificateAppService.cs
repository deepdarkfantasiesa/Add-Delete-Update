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
                .OrderBy(t => t.Id)
                .ToListAsync();

            return new ListResultDto<CertificateDto>(
                ObjectMapper.Map<List<CertificateDto>>(certificates)
            );
        }

        public async Task<Certificate> Create(CreateCertificationInput input)
        {
            var cert = ObjectMapper.Map<Certificate>(input);
            var cert2 = await _certificateRepository.InsertAsync(cert);
            return cert2;
        }

        public async Task Update(CreateCertificationInput input)
        {
            var cert = ObjectMapper.Map<Certificate>(input);
            await _certificateRepository.UpdateAsync(cert);
        }

        public async Task<ListResultDto<CertificateDto>> GetCertification(GetCertificationInput input)
        {
            var certs = await _certificateRepository
                .GetAll()
                .Where(t => t.Id == input.CertId)
                .ToListAsync();

            return new ListResultDto<CertificateDto>(
                ObjectMapper.Map<List<CertificateDto>>(certs)
                );
        }
        
        public async System.Threading.Tasks.Task Delete(DeleteCertificationInput input)
        {
            var cert = new Certificate()
            {
                Id = input.Id
            };
            await _certificateRepository.DeleteAsync(cert);
        }
    }
}
