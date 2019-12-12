using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Web.Models
{
    public class CreateCertificateViewModel
    {
        public List<SelectListItem> Cert { get; set; }

        public CreateCertificateViewModel(List<SelectListItem> cert)
        {
            Cert = cert;
        }
    }
}
