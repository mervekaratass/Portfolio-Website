using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        //Burda register  kaydı için bir view model oluşturuyoruz
        
            //aynı property tanımlar gibi tanımlıyoruz
            //Bu required gibi attributeler identity kütüphanesine aittir
            //Bu özellikleri kullanmak için using System.ComponentModel.DataAnnotations; ı dahil ederiz 
            [Required(ErrorMessage = "Lütfen adınızı girin")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Lütfen soyadınızı girin")]
            public string Surname { get; set; }

            [Required(ErrorMessage = "Lütfen kullanıcı adınızı girin")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Lütfen resim url değeri girin")]
            public string ImageUrl { get; set; }

            [Required(ErrorMessage = "Lütfen şifreyi girin")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Lütfen şiferyi tekrar girin")]
            [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "Lütfen mail girin")]
            public string Mail { get; set; }
        }
}
