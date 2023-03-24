using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;  //Data Entity tanımlamalıyız.Nuget Paketlerden EntityFramewaro paketini yükledik.

namespace TatilSeyahatSitesi.Models.Siniflar
{
    //Tablolarımızı veritabanına yansıtabilmek için Context Sınıfı oluşturuyoruz
    public class Context:DbContext  //İlgili tablolarımıza ulaşabilmek için Context sınıfından miras alıyoruz.

    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog>  Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}