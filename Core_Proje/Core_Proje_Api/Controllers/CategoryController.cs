using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {   //using demek buunu sadece burda kullanmak demek 
            using var c = new Context();
            return Ok(c.Categories.ToList());
            //listeleme işlemi yapıyoruz
            //ok metodu apilerde sonucun başarılı olduğunu gösteren bir metoddur
            //status code 200
        }

        [HttpGet("{id}")]
        public IActionResult CategoryGet(int id)
        {
            //id ye göre listeleme işlemi yapıyyoruz
            using var c = new Context();
            var value = c.Categories.Find(id);
            //buralarda manager ların kullanılmadığına dikkat et o yüzden farklı
            if(value==null)
            {
                return NotFound();
                //hiçbir şey bulunamadı metodur
            }
            else
            {
                return Ok(value);
            }

        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {//ekleme metodunu yazdık
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
            //bu geriye oluşturuldu metodunu döndürüyor
        }

        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            //silme actionunu yazdık
            using var c = new Context();
            var value = c.Categories.Find(id);
            if(value==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
                //içerik olmadan bana döndür demek nocontent

            }
        }

        [HttpPut]
        public IActionResult CategoryUpdate(Category p)
        {
            //güncelleme metodunu yazıyoruz
            using var c = new Context();
            var value = c.Find<Category>(p.CategoryID);
            if(value==null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();

            }
        }
    }
}
