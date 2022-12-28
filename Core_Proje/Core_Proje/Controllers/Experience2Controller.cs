using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    //bu sırf ajaxla nasıl ekleme listeleme silme güncelleme işlemlerini yaptığımızı görmek için 
    //yapıldı yani benim normal experience controllerımla aynı işlemi yapıyor sadece ajaxla nasıl yapıldığını görücez
    [Authorize(Roles = "Admin")]
    public class Experience2Controller : Controller
        {
            ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
            public IActionResult Index()
            {
                return View();
            }
            public IActionResult ListExperience()
            {
                var values = JsonConvert.SerializeObject(experienceManager.TGetList());
                return Json(values);
            }
            [HttpPost]
            public IActionResult AddExperience(Experience p)
            {
                experienceManager.TAdd(p);
                var values = JsonConvert.SerializeObject(p);
                return Json(values);
            }
            public IActionResult GetById(int ExperienceID)
            {
                var v = experienceManager.TGetByID(ExperienceID);
                var values = JsonConvert.SerializeObject(v);
                return Json(values);
            }
            public IActionResult DeleteExperience(int id)
            {
                var v = experienceManager.TGetByID(id);
                experienceManager.TDelete(v);
                return NoContent();
            }

        [HttpPost]
        public IActionResult UpdateExperience(int ExperienceID, string Name,string Date)
        {
            var v = experienceManager.TGetByID(ExperienceID);
            if (v != null)
            {
                v.Name = Name;
                v.Date = Date;
                experienceManager.TUpdate(v);
                var values = JsonConvert.SerializeObject(v);
                return Json(values);
            }
            else
                return Json(new object());
        }
    }
    }

