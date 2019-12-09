using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Web.Models
{
    public class CreateWorkerViewModel
    {
        public List<SelectListItem> People { get; set; }

        public CreateWorkerViewModel(List<SelectListItem> people)
        {
            People = people;
        }
    }
}
