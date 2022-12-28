using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramewoek
{
    public class EfAboutDal:GenericRepository<About>,IAboutDal
    {
        //burda son işem olarakak entity frameworkleri oluşturuyoruz ve bunlar generic repository den kalıtım alırlar
        //, ile de IAboutDal kullnmasını sağlıyorum bunun sebebi ilerd ben normal crud operasyonları dışında farklı bir metod oluşturmak istediğimde
        //onu oluşturmama imkan sağlaması için IAboutDal da imszasını atıp gelip burda sadece ona ait bir crud metodu oluşturabilicem
    }
}
