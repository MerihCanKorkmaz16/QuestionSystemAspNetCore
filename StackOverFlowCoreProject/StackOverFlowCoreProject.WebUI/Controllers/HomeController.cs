using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackOverFlowCoreProject.Business.Abstract;
using StackOverFlowCoreProject.WebUI.Models;

namespace StackOverFlowCoreProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ISoruService _soruService;
        public HomeController(ISoruService soruService)
        {
            _soruService = soruService;
        }
        public IActionResult Index(int category = 0)
        {
            var soru = _soruService.GetSoruDetay(category).OrderByDescending(x=>x.CreatedDate);
            SoruListViewModel model = new SoruListViewModel
            {
                Sorular = soru
            };
            return View(model);
        }
    }
}
