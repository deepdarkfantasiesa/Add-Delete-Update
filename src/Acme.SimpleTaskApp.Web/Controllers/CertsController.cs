using Acme.SimpleTaskApp.Certificates;
using Acme.SimpleTaskApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Web.Controllers
{
    

    public class CertsController : SimpleTaskAppControllerBase
    {
        private readonly ICertificateAppService _certificateService;

        public CertsController(ICertificateAppService certificateService)
        {
            _certificateService = certificateService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _certificateService.GetAll();                /*---1.1---*/ //这里用_certificateService变量下的GetAll()函数把证书表里的数据全部搜索出来  _certificateService变量是ICertificateAppService类型的，ICertificateAppService写在.Application项目的Certificates文件夹下，里面申明了GetAll()函数，ICertificateAppService接口由同文件夹下的CertificateAppService类继承并实现。
            var model = new CertificateIndexViewModel(output.Items);        /*---1.2---*/ //这一步实例化了一个CertificateIndexViewModel类型的变量，名字是model，实例化输入的参数是前面搜索出来的数据。这里点击CertificateIndexViewModel然后按F12跳转到定义它的地方（.Web项目下Models文件夹里CertificateIndexViewModel.cs文件）
            return View(model);                                             /*---1.3---*/ //这一步不用理解，但是必须要写！
        }

        public ActionResult Create()//待改，添加检索已有员工的语句，参考TasksController里的Create函数
        {
            return View();
        }

        public async Task<ActionResult> Update(GetCertificationInput input)
        {
            var output = await _certificateService.GetCertification(input);
            var model = new CertificateIndexViewModel(output.Items);
            return View(model);
        }
    }
}
