using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        //ilk satırdaki identityi kullnmak için olan tanımlamalardan bçylece oturum da kimin açık olduğunu bilgilerini bulabilirim 
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
      
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {//alıcı olduğumuz mesajlar
            //oturum da açık olan kişinin bilgileriini buldum
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //o kişinin mailni p ye atadım
            p = values.Email;
            //daha sonra tablomdan daha çnce service de ve managerda oluşturduğum GetListReceiverMessage ına bu bir filtreleme işlemi yapıyor
            //p yi tabloda receiver olanları getiricek böylece listeliycek
            var messageList = writerMessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }

        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {//gönderici olduğumuz mesajlar
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(p);
            return View(messageList);
        }

        [Route("")]
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }

        [Route("")]
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            //WriterMessage tablosundan bir tane p parametresi oluşturdum bu boş bir satır gibi düşün verilerini almayı bekliyor daha sonra bunu 
            //gerekli verileri aktardıktan sonra bu nesneyi tabloma ekledim
            //oturum un kime ait olduğunu bulmak için identity metodlarını kullandım
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Sender = mail;
            p.SenderName = name;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //alıcının adını almak için context ten bir c nesnesi oluşturup kullanıcılar tablosuna eriştim
            //kullanıcılar tabşosundan yazdığım alıcı maili tabloda kiminle aynıysa onu seçerek onun name ve surname ini aldım ve atadım. 
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
      
        }
    }
}
