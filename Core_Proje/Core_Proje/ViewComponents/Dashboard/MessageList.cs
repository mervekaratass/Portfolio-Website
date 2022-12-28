using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

       
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
