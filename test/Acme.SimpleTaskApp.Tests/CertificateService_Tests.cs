using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acme.SimpleTaskApp.Certificates;
using Shouldly;
using Xunit;

namespace Acme.SimpleTaskApp.Tests
{
    public class CertificateService_Tests: SimpleTaskAppTestBase
    {
        private readonly ICertificateAppService _certificateService;

        public CertificateService_Tests()
        {
            _certificateService = Resolve<ICertificateAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            //Act
            var output = await _certificateService.GetAll();

            //Assert
            //output.Items.Count.ShouldBe(1);
            output.Items.Count.ShouldBe(1);
        }
    }
}
