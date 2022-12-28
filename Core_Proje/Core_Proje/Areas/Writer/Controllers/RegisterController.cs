using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{   
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    [AllowAnonymous]

    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        //identity kütüphanesine ait manager sınıfını kullanıyorum
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        //daha sonra bunun constructor metodunu oluşturuyorum

      
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(UserRegisterViewModel p)
        {
            //aşağıda async metod çağırmak için bu metoduma async oalrak çevirdim
            //burda oluşturduğum view modelden p nesnesi alıyorum
            
                //model çalıştığında Writer user sınıfımdab bir w nesnesi oluşturup bunun içinde
                WriterUser w = new WriterUser()
                {
                    //sol taraftaki veritabanımdaki sağ  taraftaki modelimdeki adlandırma olucak şekilde
                    //modelimdeki değeri veri tablomdaki değere aktarıyorum
                    Name=p.Name,
                    Surname=p.Surname,
                    Email=p.Mail,
                    UserName=p.UserName,
                    ImageUrl=p.ImageUrl
                };
            //daha sonra manager ile identitye ait hazır metod olan createasync ile oluşturma işlemini yapıp results a atıyorum
            //createasync(user nesnem, ve şifre tanımlaması burda alınıyor)
            if (p.ConfirmPassword == p.Password)
            {  //şifereler aynı girildiyse şifreyi al ve oluştur kullanıcıyı
                var result = await _userManager.CreateAsync(w, p.Password);

                if(result.Succeeded)
                {//ekleme işlemi başarılıysa
                    //giriş sayfasına yönlendir
                    return RedirectToAction("Index", "Login");



                }
                else
                {
                    //değilse hataları ver
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View();
        }
    }
}
