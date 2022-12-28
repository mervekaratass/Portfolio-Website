using BusinessLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            //alıcısı olduğum mesajları sıralayarak getir z den aya ama ü çtane
            return View(values);


            ////aşağıdaki denemeydi
            //Context context = new Context();
            //var filter = "admin@gmail.com";
            //var list = (from x in context.Users
            //            join y in context.WriterMessages
            //            on x.Email equals y.Sender
            //            where y.Receiver == filter
            //            select new WriterMessageImageUrl
            //            {
            //                ImageUrl = x.ImageUrl,
            //                Date = y.Date,
            //                SenderName = y.SenderName,
            //                MessageContent = y.MessageContent,
            //                Id = y.WriterMessageID
            //            }).OrderByDescending(x => x.Id).Take(3).ToList();
            //return View(list);
        }
    }
}
