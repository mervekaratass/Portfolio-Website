using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {        
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {//ViewBag lerler sayfa diznim için güzel bir gürüntü sağlıycam
            //ViewBag.v1 = "Yetenek Ekleme";
            //ViewBag.v2 = "Yetenekler";
            //ViewBag.v3 = "Yetenek Ekleme;";
            //bu view bagleri sildim sadece nasıl kullanıldığını gör diye
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = skillManager.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {

            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
    
