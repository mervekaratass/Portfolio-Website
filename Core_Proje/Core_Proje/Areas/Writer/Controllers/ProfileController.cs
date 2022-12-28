using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {//burda bilgilerimi getiriyorum 
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //kullanıcı adıma göre bilgilerimi buldu ve values e atadı
            UserEditViewModel model = new UserEditViewModel();
            //daha sonra bu bilgileri model nesneme atıyorum ve modelimi döndürüyorum
            //burda modele atmmaın sebebi güncelleme işlemi yaparken model den çekip veri tabanım ayansıttığım için çekerken de verrilerimi 
            //model üzerine çekiyorum böylece doğru bir yaklaşım yapmış olurum
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureURL = values.ImageUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //yine isme göre bilgilerimi bulup valuese atıyorum
            if (p.Picture != null)
            {//resim ekleme işlemi
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            //daha sonra modelimdeki bilgileri bulduğum nesneme gerekli atama işlemleri yaparak user nesnesine atoyotum
            //user nesnesimi güncelliyotum
            user.Name = p.Name;
            user.Surname = p.Surname;
            ////şifre için özel metod kullandım 
            ///(!model.ChangePassword)
           if(p.ChangePassword==true)
            {
               user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            }
            //user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                if (p.ChangePassword == true)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                { return View(); }
            }

            return View();
        }

       

    }

}
//asp-for lar modellerin attributeleri çünkü ben buralarda model ile işlem yapıyorum