using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<WriterUser,WriterRole,int>
    //tabloları prop özelliğiyle oluştururuz fakat türleri dbset olduğu için bunu kullanmak adına dbcontext ten kalıtım sağlarız
    //idenity kütüphanelerini kullanabilmek için IdentityDbContext olarak kalıtımı değiştiriyorum zaten bunnun içinde context sınıfı var
    {
        //baglantı yolum için konfigurasyon metodunu kullanırız
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERVE_KARATAS; database=CorePprojeDB;integrated security=true");

        }
        //tablolarımızı oluşturduk mutlaka referans işlemini yapıyoruz oluşturmadan önce
        //tabloların türü dbset olmalı <>bunun içindeki varlık adım c# daki diğeri ise benim veri tabanında yansıyan tablo adım
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Announcement> Announcements { get; set; }


        public DbSet<WriterMessage> WriterMessages { get; set; }



    }
}
