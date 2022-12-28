using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);

        }
        public IActionResult AdminMessageDelete(int id)
        {
            string p;
            p="admin@gmail.com";
            var values = writerMessageManager.TGetByID(id);
           
            if (values.Receiver == p)
            {
                writerMessageManager.TDelete(values);
                return RedirectToAction("ReceiverMessageList");
            }
           else
            {
                writerMessageManager.TDelete(values);
                return RedirectToAction("SenderMessageList");
            }
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            Context c = new Context();
    
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context co = new Context();
            var usernamesurname = co.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;  
           
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
    
}
