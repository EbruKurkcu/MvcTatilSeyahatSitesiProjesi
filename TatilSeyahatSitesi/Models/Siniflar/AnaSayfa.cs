using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class AnaSayfa
    {
        //Bu tanımlamanın kolay yolu prop+tab+tab


        [Key]  //Birincil Anahtarı Belirtmek için Kullanıyoruz.
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}