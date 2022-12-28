using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewoek;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        //burada featuremanager sınıfından bir nesne oluşturuyoruz
        //bu nesnenin içerisine de IFeatureDal a karşılık gelicek olan EfFeatureDal veriyoruz
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
             //var türünde values değerine featuremanager nesnesiyle onun içinde yer alan listeleme metoduna erişip bunu valuese atıyorum
             //daha sonra view ımın içindede bu valuesi döndürüyorum
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
