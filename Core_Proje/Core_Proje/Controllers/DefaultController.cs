using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    { //ilk önce bir razor view oluşturucam bunuda ındex üzerine tıklayıp add view diyerek yapıcam
        public IActionResult Index()
        { //burası bizizm backend kodlarımzı yazıcağımız kısım diğer metotları çağırıp ıu katmanıyla burda birleştiricem
            return View();
        }
        //paartai için metodlarımızı yazıcaz ve daha sonra metod üzerinden sağ tıklayıp view oluşturucaz
        public PartialViewResult HeaderPartial()
        {
            return PartialView();   
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesajın kaydedildiği andaki tarihi veri tabanına yansıtsın
            p.Status = true;//başşlangıçta true olsun yani aktif, mesaj okunduktan sonra biz bunu false çeviricez
            messageManager.TAdd(p);//parametrelerden gelen değeri message maneger'a ekledik
            return RedirectToAction("Index");
        }


    }
}
