using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.SimpleTaskApp.Certificates;

namespace Acme.SimpleTaskApp.Web.Models
{
    public class CertificateIndexViewModel
    {
        public IReadOnlyList<CertificateDto> Certs { get; }     //赋值完成以后，.Web\Views\Certs\Index.cshtml文件可以使用Certs，现在进入.Web\Views\Certs\Index.cshtml 第29行

        public CertificateIndexViewModel(IReadOnlyList<CertificateDto> cert)
        {
            Certs = cert;                                       //这里用输入的参数cert给Certs赋值
        }
    }
}
