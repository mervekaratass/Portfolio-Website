using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesajın kaydedildiği andaki tarihi veri tabanına yansıtsın
        //    p.Status = true; //başşlangıçta true olsun yani aktif, mesaj okunduktan sonra biz bunu false çeviricez
        //    messageManager.TAdd(p); //parametrelerden gelen değeri message maneger'a ekledik
        //    return View();
        //}
    }
}
