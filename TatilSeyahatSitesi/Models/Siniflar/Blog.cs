using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DataType Tarih { get; set; }
        public string BlogImage { get; set; }
     

        //Bir Blog Birden Çok Yoruma Sahip Olabilir.
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}