using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackOverFlowCoreProject.Business.Abstract;
using StackOverFlowCoreProject.Entities.Identity;
using StackOverFlowCoreProject.WebUI.Models;

namespace StackOverFlowCoreProject.WebUI.Controllers
{
    public class Question : Controller
    {
        private ISoruService _soruService;
        private IYorumService _yorumService;
        private UserManager<AppIdentityUser> _userManager;
        private ICategoryService _categoryService;
        public Question(ISoruService soruService, IYorumService yorumService, UserManager<AppIdentityUser> userManager, ICategoryService categoryService)
        {
            _soruService = soruService;
            _yorumService = yorumService;
            _userManager = userManager;
            _categoryService = categoryService;
        }
        public IActionResult Index(int soruId)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var sorudurum = _soruService.GetById(soruId).Durum;
            var model = new UserSoruIndexViewModel
            {
                Yorumlars = _yorumService.GetYorumlars(soruId),
                Soru = _soruService.GetUserSoru(soruId),
                checkUser = _soruService.SoruSorgulama(userId),
                soruId = soruId,
                SoruDurum = sorudurum
            };
            return View(model);
        }

        public IActionResult Comment(int soruId)
        {
            var model = new YorumEklemeViewModel { soruId = soruId };
            return View(model);
        }

        [HttpPost]
        public IActionResult Comment(YorumEklemeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                AppIdentityUser user = _userManager.FindByIdAsync(userId).Result;
                model.Yorum.UserId = user.Id;
                model.Yorum.SoruId = model.soruId;
                _yorumService.AddYorum(model.Yorum);
                TempData["message"] = "Cevabınız başarıyla oluşturuldu.";
                return RedirectToAction("Index", "Question", new { soruId = model.soruId });
            }
            return View(model);
        }

        public IActionResult CloseQuestion(YorumEklemeViewModel model)
        {
            var soru = _soruService.GetById(model.soruId);
            if (soru != null)
            {
                soru.Durum = true;
                _soruService.SoruGüncelle(soru);
                TempData["message"] = "Soru başarıyla cevaplandı";
                return RedirectToAction("Index", "Question", new { soruId = soru.Id });
            }
            return RedirectToAction("Index", "Question", new { soruId = model.soruId });
        }

        public IActionResult CreateQuestion()
        {
            AddQuestionViewModel model = new AddQuestionViewModel
            {
                categories = _categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateQuestion(AddQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                model.Soru.UserId = userId;
                _soruService.SoruEkle(model.Soru);
                TempData["message2"] = "Sorunuz başarıyla oluşturuldu";
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult MyQuestion()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var model = new MyQuestionViewModel
            {
                MyQuestions = _soruService.GetMyQuestion(userId).OrderByDescending(x=>x.CreatedDate)
            };
            return View(model);
        }
    }
}
