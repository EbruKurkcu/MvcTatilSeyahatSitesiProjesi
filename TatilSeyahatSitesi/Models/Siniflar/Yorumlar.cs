using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }

        //public int BLOGID { get; set; }  //Bu yorum hangi bloğa yapıldı BlogID ile tutuyoruz.


        //Bir Yorum Yalnızca Bir Bloğa Sahip Olabilir.
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }

    }
}