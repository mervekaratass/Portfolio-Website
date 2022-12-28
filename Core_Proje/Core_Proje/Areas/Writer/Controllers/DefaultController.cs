using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{

    //Area içindeki controllerlara hangi areayı kullanıdğımız söylemem lazım sonuçta bir areasın içinde birden fazla arrea olabilir
    //bunuda aşağıdaki syntax ile sağlıyorum
    [Area("Writer")]
    //bu işlemi yaptıktan sonra area için configurasyon işlemini yapmayı unutmamalyım
    //Configurasyonumu startup.cs ye bana verilen txt eki kodu yaıştırarak yapıyorum 
    //bu kodda da hangi controllere kullanıyosam onun adını vermeliyim default olarak düzelttim configurasyonda

    [Authorize]//Bu sayfaya otantike olmadan erişemezsin dedim bu bir attribute özellik
    //bunun için birde startup dosyasına add.UseAuthentication(); adlı metodu ekliyoruz.
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        //normal listeleme mnatığı yaptık
        public IActionResult Index()
        {  
            var values = announcementManager.TGetList();
            return View(values);
        }

       public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = announcementManager.TGetByID(id);
            
            return View(announcement);
        }
    }
}
